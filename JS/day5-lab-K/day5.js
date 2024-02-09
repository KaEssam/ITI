// 1&2- use local storage to save user name and password

function ValidateName(username) {
    var usernameMessage = document.getElementById("usernameMessage");
    if (username.value.length < 3) {
        username.focus();
        username.select();
        usernameMessage.innerHTML = "<b style='color:red'>Name must be more than 3 characters</b>";
    } else {
        usernameMessage.innerHTML = "<b style='color:green'>Valid </b>";
    }
}

function matchPassword() {
    var password = document.getElementById("password").value;
    var repeatPassword = document.getElementById("repeatPassword").value;
    var repeatPasswordMessage = document.getElementById("repeatPasswordMessage");

    if (password !== repeatPassword) {
        repeatPasswordMessage.innerHTML = "<b style='color:red'>Password not match</b>";
    } else {
        repeatPasswordMessage.innerHTML = "<b style='color:green'>Password match</b>";
    }
}

function setLocalStorage(){
    localStorage.setItem("user", document.getElementById("un").value);
    localStorage.setItem("email", document.getElementById("email").value);
    localStorage.setItem("city", document.getElementById("city").value);
    localStorage.setItem("password", document.getElementById("password").value);
}

function getLocalStorage(){
    if (localStorage.user) {
        document.getElementById("un").value = localStorage.getItem("user");
    }
    if (localStorage.email) {
        document.getElementById("email").value = localStorage.getItem("email");
    }
    if (localStorage.city) {
        document.getElementById("city").value = localStorage.getItem("city");
    }
    if (localStorage.password) {
        document.getElementById("password").value = localStorage.getItem("password");
    }
}


    
// 3&4 -Make JSON Object that holds Student data

const students = [
  {
    ID: 1,
    name: "Karim Essam",
    Age: 28,
    Address: "Giza, Egypt",
    Skills: ["Programming", "Communication", "Problem Solving"],
    IsLeader: true,
  },
  {
    ID: 2,
    name: "Sarah Hany",
    Age: 29,
    Address: "Minia, Egypt",
    Skills: ["Data Analysis", "Teamwork", "Time Management"],
    IsLeader: false,
  },
  {
    ID: 3,
    name: "Ahmed Mohamed",
    Age: 21,
    Address: null,
    Skills: ["Web Development", "Creativity", "Adaptability"],
    IsLeader: false,
  },
];

students.forEach((student) => {
  console.log(`${student.name}'s skills: ${student.Skills.join(", ")}`);
});

// 6- Use AJAX to retrieve user data, and display

function displayUserData() {
  var userId = document.getElementById("userId").value;
  if (userId) {
    getUserData(userId, displayUserDataCallback);
  }
}

function displaySelectedUserData() {
  var selectedUserId = document.getElementById("userList").value;
  if (selectedUserId) {
    getUserData(selectedUserId, displayUserDataCallback);
  }
}

function getUserData(userId, callback) {
  fetch("https://reqres.in/api/users/" + userId)
    .then(response => response.json())
    .then(data => callback(data.data))
    .catch(() => alert("Failed to retrieve user data"));
}

function displayUserDataCallback(userData) {
  var userDataDiv = document.getElementById("userData");
  userDataDiv.innerHTML = `
    <p>First Name: ${userData.first_name}</p>
    <p>Last Name: ${userData.last_name}</p>
    <img src="${userData.avatar}" alt="User Avatar">
  `;
}

function getAllUsers() {
  fetch("https://reqres.in/api/users")
    .then(response => response.json())
    .then(data => populateUserList(data.data))
    .catch(() => alert("Failed to retrieve user list"));
}

function populateUserList(users) {
  var userListSelect = document.getElementById("userList");
  userListSelect.innerHTML = "";
  users.forEach(function (user) {
    var option = document.createElement("option");
    option.value = user.id;
    option.text = `${user.first_name} ${user.last_name}`;
    userListSelect.add(option);
  });
}

getAllUsers();







