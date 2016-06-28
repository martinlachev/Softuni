/**
 * Created by MartinLachev on 6/21/2016.
 */
function ParseJson(arr) {
    for (let i = 0; i < arr.length; i++) {

        let obj = JSON.parse(arr[i]);
        console.log('Name: ' + obj.name);
        console.log('Age: ' + obj.age);
        console.log('Date: ' + obj.date);

    }
}
ParseJson(['{"name":"Gosho","age":10,"date":"19/06/2005"}','{"name":"Tosho","age":11,"date":"04/04/2005"}']);