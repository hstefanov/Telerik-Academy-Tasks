//Problem 1. Make person
//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and gender

function createPerson(first,last,age,gender){
    return {
        firstname : first,
        lastname : last,
        age : age,
        gender : gender
    };
}

function problem1(){
    var people = [1,1,1,1,1,1,1,1,1,1].map(function(_,i){
        return createPerson('Person', i.toString(),i + 10, i % 2 ? true : false);
    });

    return people;
}

var p = problem1();

console.log(p);


//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)

function problem2(){
    var people = [1,1,1,1,1,1,1,1,1,1].map(function(_,i){
        return createPerson('Person', i.toString(),i + 15, i % 2 ? true : false);
    });

    console.log(people.every(function(person){
            return person.age >= 18;
    }));
}

problem2();

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)


var people = [1,1,1,1,1,1,1,1,1,1].map(function(_,i){
    return createPerson('Person', i.toString(),i + 15, i % 2 ? true : false);
});

var underaged =
    people.filter(function(item) {
        return item.age < 18;
    }).forEach(function(item) {
        console.log(item);
    });



//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

var femaleSum =
    people.filter(function(item) {
        return item.gender;
    }).reduce(function(sum, item, i, arr) {
        var count = arr.length;
        return (sum + item.age / count);
    }, 0);

console.log(femaleSum);


//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    people.sort(function(a, b) {
        return a.age - b.age;
    }).find(function(item) {
        return !item.gender;
    });

console.log(youngestMale.firstname, youngestMale.lastname);

//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

var result = people.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log(result);