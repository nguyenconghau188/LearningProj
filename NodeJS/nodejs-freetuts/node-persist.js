// Load module node-persist
var storage = require('node-persist');
 
// Hàm khởi tạo
// Load dữ liệu đã lưu trên ổ đĩa
storage.initSync({
    dir : "students"
});

// Hàm lấy danh sách sinh viên
function getAllStudents()
{
    // Lấy sinh viên từ nơi lưu trữ
    var students = storage.getItemSync('students');
     
    // Nếu không có sinh viên nào thì trả về một mảng rỗng
    if (typeof students === "undefined"){
        return [];
    }
     
    // Ngược lại sẽ trả về danh sách sinh viên
    return students;
}
 
 
// Hàm lấy chi tiết sinh viên
function getStudent(studentId)
{
    // Lấy danh sách sinh viên
    var students = getAllStudents();
     
    // Biến lưu trữ sinh viên được tìm thấy
    var matchedStudent = null;
     
    // Lặp để tìm sinh viên
    for (var i = 0; i < students.length; i++){
        if (students[i].id === studentId){
            matchedStudent = students[i];
            break;
        }
    }
     
    return matchedStudent;
}
 
 
// Hàm thêm một sinh viên
function addStudent(id, fullname)
{
     var students = getAllStudents();
     
    students.push({
        id : id,
        fullname : fullname
    });
     
    storage.setItemSync('students', students);
}
 
// Hàm xóa sinh viên
function removeStudent(studentId)
{
     var students = getAllStudents();
     
    for (var i = 0; i < students.length; i++){
        if (students[i].id === studentId){
            students.splice(i, 1);
        }
    }
     
    storage.setItemSync('students', students);
}
 
// Hàm sửa sinh viên
function editStuent(studentId, studentName)
{
     var students = getAllStudents();
 
    for (var i = 0; i < students.length; i++){
        if (students[i].id === studentId){
            students[i].fullname = studentName;
        }
    }
     
    storage.setItemSync('students', students);
}
 
// Hàm hiển thị danh sách sinh viên
function showStudents()
{
    var students = getAllStudents();
    students.forEach(function(student){
        console.log('Student: ' + student.fullname + ' (' + student.id + ')');
    });
}

// Thêm sinh viên
addStudent(1, 'Cuong');
addStudent(2, 'Kinh');
addStudent(3, 'Chinh');
addStudent(4, 'Quyen');
 
// Hiển thị danh sách sinh viên
showStudents();