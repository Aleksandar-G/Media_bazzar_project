<?php

$user = Auth::user();

print($user->id);

print($user->name);

print($user->email);

try {
    // Create DB connection
    $conn = new PDO("mysql:host=$servername;dbname=dbi425730", $uid, $pid);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e){
    var_dump("database connection fail");
    
    //echo $e->getMessage();
}    

$sth = $conn->prepare("INSERT INTO `users`(`username`, `password`, `type` , `email`) VALUES ('$user->id','$upassword',1,'$email')");
$sth->execute();



?>