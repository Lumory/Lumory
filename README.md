# Lumory
Lumory is a matchin platform for students, internships and job offers.

## Running Lumory
The use of lumory requires Docker, you must install this first. Then you can use the following commands to build and run the service.

To build lumory:
```sh
docker-compose build
```

To run lumory:
```sh
docker-compose up
```

To update the database: 
```sh
- Change appsettings.Development line 10 lumory-mariadb to localhost
- Run docker-compose up --build
- While docker is running use dotnet ef database update
- Stop docker 
- Change appsettings.Development back to lumory-mariadb
- Run docker-compose up --build
```

The frontend runs on port 3000, the backend on port 3001, phpMyAdmin on port 3002 and the database on port 3306