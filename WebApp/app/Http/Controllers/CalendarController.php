<?php



namespace App\Http\Controllers;

use Illuminate\Http\Request;
//use Auth;
use Illuminate\Support\Facades\Auth;


class CalendarController extends Controller
{
    public static function index(){

       

        $user = Auth::user();

        //print($user->id);

        //print($user->name);

        //print($user->email);

        $servername = 'localhost';
        $uid = 'root';
        $pid = '';

        try {
    // Create DB connection
            //$conn = new PDO("mysql:host=$servername;dbname=laravel", $uid, $pid);
            $PDO = \DB::connection()->getPdo();
            //$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        }
        catch(PDOException $e){
            var_dump("database connection fail");    
            //echo $e->getMessage();
        } 

        //$sth = $conn->prepare("SELECT * `work_shifts` WHERE id = '$user->id'");
        $QUERY= $PDO->prepare("SELECT * FROM `work_shifts` WHERE worker_id = '$user->id';");
        //$sth->execute();
        //$PDO->execute();
        $QUERY->execute();
        $result=$QUERY->fetchAll();

        $arr = array();

        //$result = $sth->fetchAll();
        $counter = 0;
        foreach ($result as $value) {
            $row = array();
            $row['title'] = "work";
            if($value[2] == 'Morning'){
                $originalDate = $value[3];
                $newDate = date("YYYY-mm-dd", strtotime($originalDate));
                $row['start'] = $originalDate."T"."08:00:00";
                $row['end'] = $originalDate."T"."12:00:00";
            }
            else if($value[2] == 'Afternoon'){
                $originalDate = $value[3];
                $newDate = date("YYYY-mm-dd", strtotime($originalDate));
                $row['start'] = $originalDate."T"."12:00";
                $row['end'] = $originalDate."T"."16:00";
            }
            else{
                $originalDate = $value[3];
                $newDate = date("YYYY-mm-dd", strtotime($originalDate));
                $row['start'] = $originalDate."T"."16:00:00";
                $row['end'] = $originalDate."T"."20:00:00";
            }
            //$arr = $row;
            array_push($arr,$row);
            $counter++;
        }
        //print_r($result);
        //print_r($counter);
        //for($i = 0 ;$i < 2;$i++)
       // {
       //     print_r($arr[0]=>'title');
       // }
     //  foreach($arr as $key => $value)
      //  {
       //    echo implode(" ", $value );
       //    echo ","; 
       //}
       
        for($i = 0 ;$i < count($arr);$i++)
        {
            echo "{";
            foreach($arr[$i] as $key => $value)
            {
                if($key == "end")
                {echo "$key : '$value' ";}
                else{
                echo "$key : '$value' ,";
                }
                
            }
            echo "}, ";
        }
        
       //echo implode( $arr);
       //echo (json_encode($arr));
       
    }

        
}
?>


