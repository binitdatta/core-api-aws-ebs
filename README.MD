# Steps to run DotNet Core 2.1 Apps in AWS Linux

1. Launch EC2 Instance with Amazon Lunux AMI

2. SSH into the new EC2 Instance

3. sudo yum update -y

4. sudo yum install git

5. sudo yum install docker

6. sudo service docker start

7. git clone https://github.com/binitdatta/core-api

8. cd core-api

9. sudo docker build -t core-api .

10. sudo docker run --name core-api --env ASPNETCORE_ENVIRONMENT=Development -p 80:80 core-api:latest

11. http://18.237.82.6/api/cat works.

12. Note : Steps 3 - 6 can be automated
GitHub
binitdatta/core-api
Contribute to binitdatta/core-api development by creating an account on GitHub.

The EC2 instance security group has port 80 open for all traffic