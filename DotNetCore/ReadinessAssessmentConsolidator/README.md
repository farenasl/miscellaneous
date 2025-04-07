Install ClosedXML support into the project
ClosedXML allows the project to work with MS Office documents like excels, words, powerpoints, etc

````
dotnet add package ClosedXML
````

Remove packages from the project
`````
dotnet remove package Microsoft.Office.Interop.Excel
`````

# Resourced used to develop this.
## Development
* https://www.youtube.com/watch?v=-jCLDGXwY4k
* https://stackoverflow.com/questions/52927/console-writeline-and-generic-list
* https://stackoverflow.com/questions/17321958/listcustom-to-excel-c-sharp

## Dockerization
* https://www.youtube.com/watch?v=BrKeO_Ubsr4
* https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
* https://stackoverflow.com/questions/22049212/copying-files-from-docker-container-to-host

# Pre-requisites
* dotnet sdk 9.0
* ClosedXML library
* results folder at the same level of binaries
* excelFiles folder with all excel files to consolidate
* The excel files **must** to have the same and specific format. Any modification will cause this program to fail

# Execute the code
`````
dotnet run
`````

# Execute in a container 
Remove everything previously created
`````
docker system prune -a
`````

Build docker image using Dockerfile
`````
docker build -t rac:v1 .
`````
Execute the docker container with container's console-view mode on
`````
dotnet run -it rac:v1
`````
Extract the result file from the container to the local machine
`````
dotnet cp <container_id>:<container_file_full_path> <local_path>
`````
Example
`````
docker cp a0bab273c2ed:/app/results/BMA_Technology_Readiness_Survey_Consolidated_2025_0407_230016.xlsx . 
`````