# Api Rest Test

- [Api Rest Test](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#reqister)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
    - [LikeComic](#likeComic)
      - [likeComic Request](#likeComic-request)
      - [likeComic Response](#likeComic-response)
    - [GetListLikeComic](#GetListLikeComic)
      - [GetListLikeComic Request](#GetListLikeComic-request)
      - [GetListLikeComic Response](#GetListLikeComic-response)

##Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "name": "Amichai",
  "nuip": "2324232323",
  "email": "michai@mantinband.com",
  "password": "Amik01232!"
}
```

#### Register Response

```json
{
  "id": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "name": "Amichai",
  "nuip": "2324232323",
  "email": "michai@mantinband.com",
  "token": "eyJhb..hbbQ"
}
```

### Login

```js
POST {{host}}/auth/register
```

#### Login Request

```json
{
  "email": "michai@mantinband.com",
  "password": "Amik01232!"
}
```

#### Login Response

```json
{
  "id": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "name": "Amichai",
  "nuip": "2324232323",
  "email": "michai@mantinband.com",
  "token": "eyJhb..hbbQ"
}
```

### LikeComic

```js
POST {{host}}/like/createUpdate
```

#### LikeCommit Request

```json
{
  "UserId": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "CommicId": 234,
  "Like": true,
  "Thumbnail": "",
  "Title": "Startling Stories: The Incorrigible Hulk (2004) #1",
  "Description": ""
}
```

#### LikeCommit Response

```json
{
  "UserId": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "CommicId": 234,
  "Like": true,
  "Thumbnail": "",
  "Title": "Startling Stories: The Incorrigible Hulk (2004) #1",
  "Description": ""
}
```

### GetListLikeComic
```js
Get {{host}}/like/getListLikeComic/{UserId}
```

#### GetListLikeComic Request

```json
{
  "UserId": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
},

```

#### GetListLikeComic Response

```json
{
  "UserId": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "CommicId": 234,
  "Like": true,
  "Thumbnail": "",
  "Title": "Startling Stories: The Incorrigible Hulk (2004) #1",
  "Description": ""
},
{
  "UserId": "89c2d9a-eb3e-U075-95ff-b920b55aa10U",
  "CommicId": 234,
  "Like": true,
  "Thumbnail": "",
  "Title": "Startling Stories: The Incorrigible Hulk (2004) #1",
  "Description": ""
}
```