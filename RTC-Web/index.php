<?php session_start();
ob_start();
try {
     $db = new PDO("mysql:host=localhost;dbname=rtc", "root", "");
} catch ( PDOException $e ){
     print $e->getMessage();
}
?>
<!DOCTYPE html>
<html>
<head>
	<title>RTC Web</title>
</head>
<body>
		<form method="post">
			<input type="text" name="username" placeholder="Username"> <br>
			<input type="password" name="password" placeholder="PAssword">
			<br>
			<button type="submit">Login</button>
		</form>
</body>
</html>
<?php

if ($_POST) {
    $uid = trim(@$_POST['username']);
    $pid = trim(@$_POST['password']);

    if ($uid != "" && $pid != "") {
        $query = $db->prepare("SELECT * FROM user WHERE username = ? && password = ?");
        $query->execute(array($uid, $pid));
        if ($query->rowCount()) {
            $query = $query->fetch(PDO::FETCH_OBJ);
            $_SESSION['id'] = $query->id;
            $_SESSION['username'] = $query->username;
            $_SESSION['fullname'] = $query->fullname;
            $_SESSION['status'] = $query->status;
            $queryz = $db->prepare("Update user SET status = 1 WHERE id = ?");
        $queryz->execute(array($query->id));
            header("refresh:1; url=message.php");
        }  
    }  
}
?>