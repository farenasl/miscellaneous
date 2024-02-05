This script is created due to a problem happened in my personal files.

When I do monetary transactions I save the transaction vouchers in a year's corresponding name folder

The vouchers have a naming convention detemined by the rules:
* First two digits represent the month of the transaction.
* Underscore sign ( **_** ).
* Number which represent the qty of transactions in the month

In example if the saved voucher represents the twelfth transaction of the month of March of the year 2025,
the file will be saved inside of the folder 2025 with the name 03_12.pdf

# Problem
By mistake I performed some transactions in the 1st day of February, but I saved the vouchers as January vouchers

# Reaction
After manually fixed 3 of these wrongly named files, I decided to create a shell script to practice and do it automatically 

# Actions
* Create a shell script
* Localize the execution path in the corresponding folder (path hardcoded if it's not provided as argument for the execution)
* List all files with wrong name (filters applied to avoid properly named files)
* Use command move (**mv**) to rename the files with the corresponding name

# Results
At the end all next files were renamed as follow

__*first column renamed as original incorrect name*__

__*second column renamed as final correct name*__

|Conversion            |
------------------------
|01_34.pdf renamed as 02_03.pdf|
|01_35.pdf renamed as 02_04.pdf|
|01_36.pdf renamed as 02_05.pdf|
|01_37.pdf renamed as 02_06.pdf|
|01_38.pdf renamed as 02_07.pdf|
|01_39.pdf renamed as 02_08.pdf|
|01_40.pdf renamed as 02_09.pdf|
|01_41.pdf renamed as 02_10.pdf|
|01_42.pdf renamed as 02_11.pdf|
|01_43.pdf renamed as 02_12.pdf|
|01_44.pdf renamed as 02_13.pdf|
|01_45.pdf renamed as 02_14.pdf|
|01_46.pdf renamed as 02_15.pdf|
|01_47.pdf renamed as 02_16.pdf|
|01_48.pdf renamed as 02_17.pdf|
|01_49.pdf renamed as 02_18.pdf|
|01_50.pdf renamed as 02_19.pdf|
|01_51.pdf renamed as 02_20.pdf|
|01_52.pdf renamed as 02_21.pdf|
|01_53.pdf renamed as 02_22.pdf|
|01_54.pdf renamed as 02_23.pdf|
|01_55.pdf renamed as 02_24.pdf|
|01_56.pdf renamed as 02_25.pdf|
|01_57.pdf renamed as 02_26.pdf|
|01_58.pdf renamed as 02_27.pdf|