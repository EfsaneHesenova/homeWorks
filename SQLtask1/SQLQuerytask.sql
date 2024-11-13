CREATE DATABASE CountrytaskDB
USE CountrytaskDB

CREATE TABLE regions
(
	region_id INT PRIMARY KEY IDENTITY,
	region_name NVARCHAR(25) UNIQUE

)
CREATE TABLE countries
(
	country_id CHAR(2) PRIMARY KEY,
	country_name NVARCHAR(40) UNIQUE,
	region_id int
	FOREIGN KEY(region_id) REFERENCES regions(region_id)
)
CREATE TABLE locations
(
	location_id INT PRIMARY KEY IDENTITY,
	street_address NVARCHAR(25) UNIQUE,
	postal_code NVARCHAR(12) UNIQUE,
	city NVARCHAR(30),
	state_province NVARCHAR(12) UNIQUE,
	country_id CHAR(2)
	FOREIGN KEY(country_id) REFERENCES countries(country_id)
)
CREATE TABLE departments
(
	department_id INT PRIMARY KEY IDENTITY,
	department_name NVARCHAR(30) UNIQUE,
	manager_id INT UNIQUE,
	location_id INT
	FOREIGN KEY(location_id) REFERENCES locations(location_id)
)
CREATE TABLE jobs
(
	job_id NVARCHAR(10) PRIMARY KEY,
	job_title NVARCHAR(35),
	min_salary INT,
	max_salary INT
)
CREATE TABLE employees
(
	employee_id INT PRIMARY KEY IDENTITY,
	first_name NVARCHAR(20),
	last_name NVARCHAR(25),
	email NVARCHAR(25),
	phone_number NVARCHAR(20),
	hire_date DATE,
	job_id NVARCHAR(10),
	salary int,
	comission_pct int,
	manager_id int,
	department_id int
	FOREIGN KEY(job_id) REFERENCES jobs(job_id),
	FOREIGN KEY(department_id) REFERENCES departments(department_id)
)

CREATE TABLE job_history
(
	employee_id INT IDENTITY,
	start_date DATE,
	end_date DATE,
	job_id NVARCHAR(10),
	department_id INT,
	PRIMARY KEY(employee_id, start_date ),
	FOREIGN KEY(department_id) REFERENCES departments(department_id),
	FOREIGN KEY(job_id) REFERENCES jobs(job_id),
	FOREIGN KEY(employee_id) REFERENCES employees(employee_id)
)

CREATE TABLE job_grades
(
	grade_level NVARCHAR(2) PRIMARY KEY,
	lowest_sal int,
	highest_sal INT,
)


