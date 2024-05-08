-- Create the database

CREATE DATABASE LibraryDatabase;
USE LibraryDatabase;

-- Create the tables


CREATE TABLE Admin (
  A_id varchar(255)  PRIMARY KEY,
  name VARCHAR(255),
  Pass VARCHAR(255),
  mail VARCHAR(255)
);

CREATE TABLE Publisher (
  name VARCHAR(255),
  pub_id varchar(255)  PRIMARY KEY,
  pub_phone VARCHAR(255),

);

CREATE TABLE author (
  name VARCHAR(255),
  author_id varchar(255)  PRIMARY KEY
);

CREATE TABLE BOOK (
  ISBN varchar(255)  PRIMARY KEY,
  Book_name VARCHAR(255),
  year VARCHAR(255),
  numOfbooks INTEGER,
  number_of_copies INTEGER,
  A_id varchar(255),
  pub_id varchar(255),
  author_id varchar(255),
  FOREIGN KEY (A_id) REFERENCES Admin(A_id),
   FOREIGN KEY (pub_id) REFERENCES Publisher(pub_id),
	FOREIGN KEY (author_id) REFERENCES author(author_id)
);

CREATE TABLE Student (
  first_name VARCHAR(255),
  last_name VARCHAR(255),
  s_id varchar(255)  PRIMARY KEY,
  pass VARCHAR(255),
  address VARCHAR(255),
  mail VARCHAR(255),
  B_date VARCHAR(255),
  age INTEGER,
  St_phone VARCHAR(255),
  
);

CREATE TABLE Copy (
  copyNum INTEGER,
  Status VARCHAR(255),
  ISBN varchar(255),
  FOREIGN KEY (ISBN) REFERENCES BOOK(ISBN)
);

CREATE TABLE Borrow (
  return_date VARCHAR(255),
  Issue_date VARCHAR(255),
  s_id varchar(255) ,
  ISBN varchar(255) ,
  PRIMARY KEY (s_id, ISBN),
  FOREIGN KEY (s_id) REFERENCES Student(s_id),
  FOREIGN KEY (ISBN) REFERENCES BOOK(ISBN)
);
