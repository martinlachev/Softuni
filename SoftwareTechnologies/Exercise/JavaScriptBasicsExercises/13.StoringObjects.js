/**
 * Created by MartinLachev on 6/21/2016.
 */
function StoringObjects(arr) {
    let temp = '';
    for (let i = 0; i < arr.length; i++) {
        temp = arr[i].split(" ");
        temp.splice(1,1);
        temp.splice(2,1);

        let obj ={Name:temp[0],Age:temp[1],Grade:temp[2]};
        console.log('Name: ' + obj.Name);
        console.log('Age: ' + obj.Age);
        console.log('Grade: ' + obj.Grade);
    }

}
StoringObjects(['Pesho -> 13 -> 6.00']);