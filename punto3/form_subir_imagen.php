<!DOCTYPE html>
<html>
<head>
    
   
<title>Subir Imagen</title>
    
    <

   
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        h2 {
            text-align: center;
            color: #333;
            margin-top: 40px;
        }

        form {
            width: 300px;
            margin: 0 auto;
            background-color: #fff;
            border: 1px solid #ccc;
            padding: 20px;
            border-radius: 5px;
            margin-top: 20px;
        }

        input[type="file"] {
            margin-bottom: 10px;
        }

        input[type="submit"] {
            background-color: #4CAF50;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>

</
</head>
<body>
    
   
<h2>Subir una imagen</h2>
    <form action="confirmacion.php" method="POST" enctype="multipart/form-data">
        <input type="file" name="image" required>
        
       
<input type="submit" name="submit" value="Subir Imagen">
    
   
</form>

</
</body>
</html>
