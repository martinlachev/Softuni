/**
 * Created by MartinLachev on 6/20/2016.
 */
function largest3Numbers(arr) {
    arr.reverse()
    for(let i =0;i<arr.length;i++ )
    if(i<3)
    console.log(arr[i])

}
largest3Numbers(['10','30','15','20','50']);