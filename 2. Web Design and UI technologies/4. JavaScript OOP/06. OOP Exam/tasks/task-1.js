function solve(){
    var module = (function(){

        var item,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog,
            validator,
            idGeneratorFactory;

        idGeneratorFactory = {
            get : function() {
                return (function(){
                        var lastId = 0;
                        return {
                            getNext : function(){
                                return lastId += 1;
                            }
                        }
                }());
            }

        };

        validator = (function(){
            var CONSTS = {
                ID : {
                    MIN : 0.0000,
                    MAX : Infinity
                },
                NAME : {
                    MIN : 2,
                    MAX : 40
                },
                DESCRIPTION : {
                    MIN : 1,
                    MAX : Infinity
                },
                GENRE : {
                    MIN : 2,
                    MAX : 20
                },
                RATING : {
                    MIN : 1,
                    MAX : 5
                },
                DURATION : {
                    MIN : 0.00001,
                    MAX : Infinity
                },
                PATTERN : {
                    MIN : 1,
                    MAX : Infinity
                },
                COUNT : {
                    MIN : 1,
                    MAX : Infinity
                }
            };

            function validateString(str,min,max) {
                if (typeof str !== 'string' ||
                    str.length < min ||
                    str.length > max) {
                    throw  new Error('The string must have between ' + min + ' and ' + max + ' chracters');
                }
            }

            function validateNumber(n,min,max){
                if(typeof  n !== 'number' ||
                    n < min ||
                    n > max) {
                    throw  new Error('The number must be between ' + min + ' and ' + max);
                }
            }

            function isNotChar(ch){
                return isNaN(+ch);
            }

            return {
                validateId : function(id){
                    validateNumber(id,CONSTS.ID.MIN,CONSTS.ID.MAX);
                },
                validateName : function(name){
                    validateString(name,CONSTS.NAME.MIN,CONSTS.NAME.MAX);
                },
                validateISBN : function(isbn){
                    var isString = typeof(isbn) === 'string';
                    var hasCorrectLenght = isbn.length === 10 || isbn.length === 13;
                    var hasOnlyDigis = isbn.split('').some(isNotChar);
                    if(!isString || !hasCorrectLenght || hasOnlyDigis){
                        throw  new Error('ISBN must contain exacly 10 or 13 digits');
                    }
                },
                validateDescription : function(description){
                    validateString(description,CONSTS.DESCRIPTION.MIN,CONSTS.DESCRIPTION.MAX);
                },
                validateRating : function(rating){
                    validateNumber(rating,CONSTS.RATING.MIN,CONSTS.GENRE.MAX);
                },
                validateDuration : function(duration){
                    validateNumber(duration,CONSTS.DURATION.MIN,CONSTS.DURATION.MAX);
                },
                validateGenre : function(genre){
                    validateString(genre,CONSTS.GENRE.MIN,CONSTS.GENRE.MAX);
                },
                validatePattern : function(pattern){
                    validateString(pattern,CONSTS.PATTERN.MIN,CONSTS.PATTERN.MIN);
                },
                validateCount : function(count){
                    validateNumber(count,CONSTS.PATTERN.MIN,CONSTS.PATTERN.MAX);
                }
            };

        }());

        item = (function(){
            var item = Object.create({});

            var idGenerator = idGeneratorFactory.get();

            Object.defineProperty(item,'init',{
                value : function(name,description){
                    this._id = idGenerator.getNext();
                    this.name = name;
                    this.description = description;
                    return this;
                }
            });

            Object.defineProperty(item,'name',{
                get : function(){
                    return this._name;
                },
                set : function(value){
                    validator.validateName(value);
                    this._name = value;
                }
            });

            Object.defineProperty(item,'description',{
                get : function(){
                    return this._description;
                },
                set : function(value){
                    validator.validateDescription(value);
                    this._description = value;
                }
            });

            Object.defineProperty(item,'id',{
                get : function(){
                    return this._id;
                }
            });

            return item;
        }());


        book = (function(parent){
            var book = Object.create(parent);

            Object.defineProperty(book,'init',{
                value : function(name,isbn,genre,description){
                    parent.init.call(this,name,description);
                    this.isbn = isbn;
                    this.genre = genre;
                    return this;
                }
            });

            Object.defineProperty(book,'isbn',{
                get : function(){
                    return this._isbn;
                },
                set : function(value){
                    validator.validateISBN(value);
                    this._isbn = value;
                }
            });

            Object.defineProperty(book,'genre',{
                get : function(){
                    return this._genre;
                },
                set : function(value){
                    validator.validateGenre(value);
                    this._genre = value;
                }
            });

            return book;
        }(item));

        media = (function(parent){
            var media = Object.create(parent);

            Object.defineProperty(media,'init',{
                value : function(name,rating,duration,description){
                    parent.init.call(this,name,description);
                    this.rating = rating;
                    this.duration = duration;
                    return this;
                }
            });

            Object.defineProperty(media,'rating',{
                get : function(){
                    return this._rating;
                },
                set : function(value){
                    validator.validateRating(value);
                    this._rating = value;
                }
            });

            Object.defineProperty(media,'duration',{
                get : function(){
                    return this._duration;
                },
                set : function(value){
                    validator.validateDuration(value);
                    this._duration = value;
                }
            });

            return media;
        }(item));

        catalog = (function(){
            var catalog = Object.create({});

            var idGenerator = idGeneratorFactory.get();

            Object.defineProperty(catalog,'init',{
                value : function(name){
                    this._id = idGenerator.getNext();
                    this.name = name;
                    this.items = [];
                    return this;
                }
            });

            Object.defineProperty(catalog,'name',{
                get : function(){
                    return this._name;
                },
                set : function(value){
                    validator.validateName(value);
                    this._name = value;
                }
            });

            catalog._validateItem = function(item){
                validator.validateId(item.id);
                validator.validateName(item.name);
                validator.validateDescription(item.description);
            }

            Object.defineProperty(catalog,'add',{
                value : function(item){
                    if(typeof (item) === 'undefined'){
                        throw  new Error('undefined cannot be added to catalog');
                    }

                    if(typeof (item.length) !== 'undefined'){
                        return this.add.apply(this,item);
                    }

                    var itemsToAdd = [],
                        items = [].slice.call(arguments,0),
                        that = this;

                    items.forEach(function(item){
                        that._validateItem(item);
                        itemsToAdd.push(item);
                    });

                    [].push.apply(this.items,itemsToAdd);

                    return this;
                }
            });


            Object.defineProperty(catalog,'find',{
                value : function(options){
                    if(typeof (options) === 'undefined'){
                        throw  new Error('Id must be number');
                    }
                    var isOnlyId = false,
                        result;

                    if(typeof (options) === 'number'){
                        options = {
                            id : options
                        };
                        isOnlyId = true;
                    }

                    result = this.items.filter(function(item){
                            return Object.keys(options)
                                .every(function(key){
                                    return options[key] === item[key];
                                });
                    });

                    if(isOnlyId){
                        if(result.length){
                            return result[0];
                        }
                        return null;
                    }

                    return result;
                }
            });

            Object.defineProperty(catalog,'search',{
                value : function(pattern){
                    validator.validatePattern(pattern);
                    pattern = pattern.toLowerCase();
                    return this.items.filter(function(item){
                        return item.name.toLowerCase().indexOf(pattern) >= 0 ||
                                item.name.toLowerCase().indexOf(pattern) >= 0;
                    });
                }
            });


            return catalog;
        }());


        bookCatalog = (function(parent){
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog,'init',{
                value : function(name){
                    parent.init.call(this,name);
                    return this;
                }
            });

            bookCatalog._validateItem = function(book){
                parent._validateItem(book);
                validator.validateGenre(book.genre);
                validator.validateISBN(book.isbn);
            }

            Object.defineProperty(bookCatalog,'getGenres',{
                value : function(){
                    var genres = {};
                    this.items.forEach(function(item){
                        genres[item.genre.toLowerCase()] = 1;
                    });
                    return Object.keys(genres);
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function(parent){
            var mediaCatalog = Object.create(parent);

            mediaCatalog._validateItem = function(media){
                parent._validateItem.call(this);
                validator.validateDuration(media.duration);
                validator.validateRating(media.rating);
            };

            Object.defineProperty(mediaCatalog,'getTop',{
                value : function(count){
                    validator.validateCount(count);
                    var items = this.items.slice();
                    items.sort(function(i1,i2){
                        return i2.rating - i1.rating;
                    });

                    return items.slice(count,0)
                        .map(function(item){
                            return{
                                id : item.id,
                                name : item.name
                            };
                        });
                }
            });


            Object.defineProperty(mediaCatalog,'getSortedByDuration',{
               value : function() {
                   var itemsToReturn = this.items.slice();
                   itemsToReturn.sort(function(i1,i2){
                       if(i1.duration === i2.duration){
                           return i1.id - i2.id;
                       }
                       return i2.duration - i1.duration;
                   });
               }
            });

            return mediaCatalog;
        }(catalog));

        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book)
                    .init(name, isbn, genre, description);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media)
                    .init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog)
                    .init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog)
                    .init(name);
            }
        };

    }());

    return module;
}


module.exports = solve;