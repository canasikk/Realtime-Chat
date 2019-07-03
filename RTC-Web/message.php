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
        <META http-equiv="Refresh" content="5">

	<title>RTC Web</title>
</head>
<body>
    <h5>I didn't use Ajax for not need</h5>
    <div class="contrainer" style="width: 960px;">
        <div class="left" style="float: left; margin-right: 50px;" >
            <ul>
            <?php 
            $query = $db->query("SELECT * FROM user Where status = 1", PDO::FETCH_OBJ);
                     if ($query) {
                         foreach ($query as $sorgu) {
                             ?>
                              <li><?php echo $sorgu->username ?>  (<?php echo $sorgu->fullname; ?>)</li>
                         <?php }
                     } ?>
                     </ul>
        </div>
        <div class="right" style="float: left;">
            
            <table>
                <?php 
            $query = $db->query("SELECT * FROM message Order By id desc LIMIT 10  ", PDO::FETCH_OBJ);
                     if ($query) {
                         foreach ($query as $sorgu) {
                             ?>
                             <tr>
                              <td><?php echo $sorgu->time ?>  (<?php echo $sorgu->fullname; ?>) <?php echo $sorgu->msg; ?></td>
                              </tr>
                         <?php }
                     } ?>
            </table>

            <form method="post">
                <input type="text" name="msg"> 
                <button type="submit">Send</button>
            </form>

        </div>
    </div>
		  
</body>
</html>
 
<?php
if ($_POST) {
    $txt =$_POST['msg'];
 
     
            $query = $db->prepare("insert into message set time = ?,fullname = ? ,msg = ?");
            $query->execute(array(date('H:i:s'),$_SESSION['fullname'],$txt));
            if ($query){
                 
                header("refresh:0 url=message.php");
            }
 
} ?>