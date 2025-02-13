
# Ambev Developer Evaluation - Web API

This README provides a step-by-step guide to build and run the Ambev Developer Evaluation Web API using Docker Compose.

## Prerequisites

- Docker Desktop (or Docker Engine) installed and running.

## Getting Started

1. **Clone the repository:**

   ```bash
   git clone https://github.com/fabiodiez/abi-gth-omnia-developer-evaluation.git
   cd abi-gth-omnia-developer-evaluation/template/backend
   ```

2. **Build the Docker images:**

   Open a terminal in the root directory of the project (where the `docker-compose.yml` file is located) and run:

   ```bash
   docker-compose build
   ```

   This command will build the Docker image for the Web API based on the `Dockerfile` in the `src/Ambev.DeveloperEvaluation.WebApi` directory. It will also pull the images for the database (PostgreSQL), NoSQL database (MongoDB), and cache (Redis) from Docker Hub.

3. **Run the Docker containers:**

   ```bash
   docker-compose up -d
   ```

   This command will start the containers in detached mode (in the background).

4. **Apply database migrations:**

   The database migrations are automatically applied when the Web API container starts. This is handled by the `entrypoint.sh` script in the `Dockerfile`. The script waits for the PostgreSQL database to be ready and then runs the Entity Framework Core migrations.  It retries the migrations until they succeed to handle cases where the database isn't immediately available.

   **Important:** Make sure the connection string in the `entrypoint.sh` script (`dotnet ef database update ...`) is correct and matches your PostgreSQL configuration.  Specifically, ensure the database container name (`ambev.developerevaluation.database`) is correct.

5. **Access the application:**

   Once the containers are running and the migrations are complete, you can access the Web API in your browser at `http://localhost:8080` (or `https://localhost:8081` if you have HTTPS configured).

## Stopping the Containers

To stop the containers, run the following command in the project's root directory:

```bash
docker-compose down
```

## Troubleshooting

- **Container logs:** To view the logs for a specific container (e.g., the Web API), run:

  ```bash
  docker-compose logs ambev_developer_evaluation_webapi -f
  ```

- **Database connection errors:** If you encounter database connection errors, double-check the connection string in the `entrypoint.sh` script, especially the database name, user, password, and container name. Ensure that the PostgreSQL container is running and accessible.  The `docker-compose logs ambev_developer_evaluation_database` command can help diagnose PostgreSQL issues.

- **Migration errors:** If the migrations fail, examine the logs for the Web API container (`docker-compose logs ambev_developer_evaluation_webapi -f`) for details about the error. Common causes include incorrect connection strings, missing migrations, or database schema issues.

- **Port conflicts:** If you have other applications running on ports 8080 or 8081, you can change the port mappings in the `docker-compose.yml` file.  Make sure the `EXPOSE` ports in your `Dockerfile` also match.

## Project Structure

- `docker-compose.yml`: Defines the services (containers) and their configuration.
- `src/Ambev.DeveloperEvaluation.WebApi/Dockerfile`: Contains the instructions for building the Web API Docker image.
- `src/Ambev.DeveloperEvaluation.WebApi/entrypoint.sh`: A script that runs inside the Web API container to apply database migrations and then start the application.
- `src/Ambev.DeveloperEvaluation.WebApi/Migrations`: Contains the Entity Framework Core migration files.

## Additional Notes

- The `docker-compose.yml` file uses environment variables for sensitive information (e.g., database passwords).  Although the provided `docker-compose.yml` has the password hardcoded for demonstration, in a production environment, it is strongly recommended to use environment variables or Docker secrets for managing sensitive data.
- The `.dockerignore` file (if present) in the `src/Ambev.DeveloperEvaluation.WebApi` directory helps to reduce the size of the Docker image by excluding unnecessary files.  This is a best practice.

This README provides a basic guide to running the application using Docker Compose. For more detailed information about the project structure, API endpoints, or other aspects, please refer to the project documentation or the code itself.
```

To use this README:

1. **Copy the entire text above.**
2. **Create a file named `README.md` (exactly like that, case-sensitive) in the root directory of your project (the same directory as your `docker-compose.yml` file).**
3. **Paste the copied text into the `README.md` file.**
4. **Save the file.**

Now you have a `README.md` file that you can include in your repository.  Remember to replace `https://github.com/fabiodiez/abi-gth-omnia-developer-evaluation.git` with the actual URL of your Git repository.
