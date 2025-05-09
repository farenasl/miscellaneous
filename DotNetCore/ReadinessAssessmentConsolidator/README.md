# Introduction
This is not more than a simple Excel data consolidator app. This app consider an static structure to consolidate data from different Excel files and then, generate a results file with all information consolidated in just one file.

**This project was made based on the structure used for the BMA Pilot, any change on the structure of the files to consolidate will cause the program to fail.
Future versions could consider dynamic structures and error handling.**

# End-User execution
## Pre-Requirements
* Operative System: Windows x64
* [Download executable file](https://mysite.bhpbilliton.com/:u:/g/personal/fabian_arenas_bhp_com/EfbsGopFDg5NhpwspIO6zXEBYIIjiQWWOxD9Kf_ZC9Weug?e=3rDwEH)
 
# Execute the application in your local machine
* Unzip downloaded file
* Go to the path **ReadinessAssessmentConsolidator v1.0/win-x64/publish/**
* Paste all the excel files that you want to consolidate inside of the folder **excelFiles**
* Double-click over the executable **ReadinessAssessmentConsolidator.exe**
* Check the generated file inside the folder **results**

# Development resources
## Resources used to develop this.
### Software Development
* https://www.youtube.com/watch?v=-jCLDGXwY4k
* https://stackoverflow.com/questions/52927/console-writeline-and-generic-list
* https://stackoverflow.com/questions/17321958/listcustom-to-excel-c-sharp
* https://github.com/ClosedXML/ClosedXML

## Dockerization
* https://www.youtube.com/watch?v=BrKeO_Ubsr4
* https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
* https://stackoverflow.com/questions/22049212/copying-files-from-docker-container-to-host

## Publication
* https://blog.magnusmontin.net/2019/09/22/single-file-exes-in-net-core/

# Development Pre-requisites
* dotnet sdk 9.0
* ClosedXML library
* Docker Desktop (only in case you want to run this in a docker container)
* results folder at the same level of binaries
* excelFiles folder with all excel files to consolidate
* The excel files **must** to have the same and specific format. Any modification will cause this program to fail and errors are not getting handled

# How-To
## Manage packages of the project
Install ClosedXML support into the project
ClosedXML allows the project to work with MS Office documents like excels, words, powerpoints, etc

````
dotnet add package ClosedXML
````

Remove packages from the project
`````
dotnet remove package Microsoft.Office.Interop.Excel
`````

## Build the code
`````
dotnet build
`````

## Execute the code
`````
dotnet run
`````

## Generate executable binary
`````
dotnet publish -r win-x64 -c release /p:PublishSingleFile=true
`````

# Manage Docker Containers/Images 
Remove everything previously created
`````
docker system prune -a
`````

List containers deployed in your local machine
`````
docker ps -a
`````

Build docker image using Dockerfile
`````
docker build -t rac:v1 .
`````
Execute the docker container with container's console-view mode on
`````
docker run -it rac:v1
`````
Extract the result file from the container to the local machine
`````
docker cp <container_id>:<container_file_full_path> <local_path>
`````
Example
`````
docker cp bff1f2ec66d0:/app/results/BMA_Technology_Readiness_Survey_Consolidated_20250422_185657.xlsx . 
`````