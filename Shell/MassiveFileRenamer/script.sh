#!/bin/sh
# This program receive a path, take all files inside
# and rename them based on specific criterias

# To execute the script we first need to give it execution permits
# Use the command chmod 755 YourScriptName.sh

# Execution with
# ./script.sh /Users/farenasl/MEGA/Movimientos\ Cuentas/Propias/Comprobantes/Transferencias/Inversiones/2024

[[ ! -z $1 ]] && folder_path=$1 || folder_path="/Users/farenasl/MEGA/Movimientos Cuentas/Propias/Comprobantes/Transferencias/Inversiones/2024"

echo "Using path $folder_path"
cd "$folder_path"
current_path=$(pwd)

echo "You're located on: $current_path"

files_qty=0
base_iterator=3
for entry in 01_3[4-9].pdf 01_[4-5][0-9].pdf
do
    #[[ $base_iterator -lt 10 ]] && echo "$entry -> 02_0$base_iterator.pdf" || echo "$entry -> 02_$base_iterator.pdf"
    [[ $base_iterator -lt 10 ]] && mv "$entry" "02_0$base_iterator.pdf" || mv "$entry" "02_$base_iterator.pdf"
    (( files_qty++ ))
    (( base_iterator++ ))
#    echo "The file $entry will be renamed as 02_0$base_iterator.pdf"
done

echo "Total quantity of renamed files: $files_qty"
