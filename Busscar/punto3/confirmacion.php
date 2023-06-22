<?php
if (isset($_POST['confirm'])) {
    $file = $_FILES['image'];

    $fileName = $file['name'];
    $fileTmpName = $file['tmp_name'];
    $fileSize = $file['size'];
    $fileError = $file['error'];

    // Obtener la extensión del archivo
    $fileExt = strtolower(pathinfo($fileName, PATHINFO_EXTENSION));

    // Verificar jpg
    if ($fileExt === 'jpg') {
        if ($fileError === 0) {
            // Directorio temporal
            $tmpDirectory = 'tmp/';

            // Directorio después de la confirmación
            $targetDirectory = 'images/';

            // Mover el archivo al directorio temporal
            $tmpFilePath = $tmpDirectory . $fileName;
            move_uploaded_file($fileTmpName, $tmpFilePath);

            // Verificar si el archivo se movió correctamente al directorio temporal
            if (file_exists($tmpFilePath)) {
                // Copiar el archivo al directorio final
                $targetFilePath = $targetDirectory . $fileName;
                copy($tmpFilePath, $targetFilePath);

                // Verificar si se copió correctamente 
                if (file_exists($targetFilePath)) {
                    // Borrar archivo de tmp
                    unlink($tmpFilePath);

                    echo "Archivo guardado y confirmado exitosamente.";
                } else {
                    echo "No se pudo copiar el archivo al directorio final.";
                }
            } else {
                echo "No se pudo mover el archivo al directorio temporal.";
            }
        } else {
            echo "Error al subir el archivo. Código de error: " . $fileError;
        }
    } else {
        throw new Exception("Archivo erróneo. Solo se permiten archivos JPG.");
    }
}
?>
