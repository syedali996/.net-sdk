# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`

## Methods

* [GET Lists-Format](../../doc/controllers/api.md#get-lists-format)
* [GET Lists-Date-List-Json](../../doc/controllers/api.md#get-lists-date-list-json)
* [GET Lists-Full-Overview-Format](../../doc/controllers/api.md#get-lists-full-overview-format)
* [GET Lists-Overview-Format](../../doc/controllers/api.md#get-lists-overview-format)
* [GET Lists-Names-Format](../../doc/controllers/api.md#get-lists-names-format)
* [GET Lists-Best-Sellers-History-Json](../../doc/controllers/api.md#get-lists-best-sellers-history-json)
* [GET Reviews-Format](../../doc/controllers/api.md#get-reviews-format)


# GET Lists-Format

Get Best Sellers list.  If no date is provided returns the latest list.

```csharp
GETListsFormatAsync(
    string list,
    string bestsellersDate = null,
    string publishedDate = null,
    int? offset = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `list` | `string` | Query, Required | The name of the Times best sellers list (hardcover-fiction, paperback-nonfiction, ...).<br>The /lists/names service returns all the list names.<br>The encoded list names are lower case with hyphens instead of spaces (e.g. e-book-fiction, instead of E-Book Fiction). |
| `bestsellersDate` | `string` | Query, Optional | YYYY-MM-DD<br><br>The week-ending date for the sales reflected on list-name. Times best sellers lists are compiled using available book sale data. The bestsellers-date may be significantly earlier than published-date. For additional information, see the explanation at the bottom of any best-seller list page on NYTimes.com (example: Hardcover Fiction, published Dec. 5 but reflecting sales to Nov. 29).<br>**Constraints**: *Pattern*: `^\d{4}-\d{2}-\d{2}$` |
| `publishedDate` | `string` | Query, Optional | YYYY-MM-DD<br><br>The date the best sellers list was published on NYTimes.com (different than bestsellers-date).  Use "current" for latest list.<br>**Constraints**: *Pattern*: `^\d{4}-\d{2}-\d{2}$` |
| `offset` | `int?` | Query, Optional | Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list.<br>**Constraints**: *Multiple Of*: `20` |

## Response Type

[`Task<Models.GETListsFormatResponse>`](../../doc/models/get-lists-format-response.md)

## Example Usage

```csharp
string list = "hardcover-fiction";

try
{
    GETListsFormatResponse result = await aPIController.GETListsFormatAsync(list, null, null, null);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 1,
  "last_modified": "2016-03-11T13:09:01-05:00",
  "results": [
    {
      "list_name": "Hardcover Fiction",
      "display_name": "Hardcover Fiction",
      "bestsellers_date": "2016-03-05",
      "published_date": "2016-03-20",
      "rank": 5,
      "rank_last_week": 2,
      "weeks_on_list": 2,
      "asterisk": 0,
      "dagger": 0,
      "amazon_product_url": "http://www.amazon.com/Girls-Guide-Moving-On-Novel-ebook/dp/B00ZNE17B4?tag=thenewyorktim-20",
      "isbns": [
        {
          "isbn10": "0553391925",
          "isbn13": "9780553391923"
        }
      ],
      "book_details": [
        {
          "title": "A GIRL'S GUIDE TO MOVING ON",
          "description": "A mother and her daughter-in-law both leave unhappy marriages and take up with new men.",
          "contributor": "by Debbie Macomber",
          "author": "Debbie Macomber",
          "contributor_note": "",
          "price": 0,
          "age_group": "",
          "publisher": "Ballantine",
          "primary_isbn13": "9780553391923",
          "primary_isbn10": "0553391925"
        }
      ],
      "reviews": [
        {
          "book_review_link": "",
          "first_chapter_link": "",
          "sunday_review_link": "",
          "article_chapter_link": ""
        }
      ]
    }
  ]
}
```


# GET Lists-Date-List-Json

Get Best Sellers list by date.

```csharp
GETListsDateListJsonAsync(
    string date,
    string list,
    int? offset = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `date` | `string` | Template, Required | YYYY-MM-DD or "current"<br><br>The date the best sellers list was published on NYTimes.com.  Use "current" to get latest list.<br>**Constraints**: *Pattern*: `^(\d{4}-\d{2}-\d{2}\|current)$` |
| `list` | `string` | Template, Required | Name of the Best Sellers List (e.g. hardcover-fiction). You can get the full list of names from the /lists/names.json service. |
| `offset` | `int?` | Query, Optional | Sets the starting point of the result set (0, 20, ...).  Used to paginate thru books if list has more than 20. Defaults to 0.  The num_results field indicates how many books are in the list.<br>**Constraints**: *Multiple Of*: `20` |

## Response Type

[`Task<Models.GETListsDateListJsonResponse>`](../../doc/models/get-lists-date-list-json-response.md)

## Example Usage

```csharp
string date = "date4";
string list = "list2";

try
{
    GETListsDateListJsonResponse result = await aPIController.GETListsDateListJsonAsync(date, list, null);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 15,
  "last_modified": "2015-12-25T13:05:20-05:00",
  "results": {
    "list_name": "Trade Fiction Paperback",
    "bestsellers_date": "2015-12-19",
    "published_date": "2016-01-03",
    "display_name": "Paperback Trade Fiction",
    "normal_list_ends_at": 10,
    "updated": "WEEKLY",
    "books": [
      {
        "rank": 1,
        "rank_last_week": 0,
        "weeks_on_list": 60,
        "asterisk": 0,
        "dagger": 0,
        "primary_isbn10": "0553418025",
        "primary_isbn13": "9780553418026",
        "publisher": "Broadway",
        "description": "Separated from his crew, an astronaut embarks on a quest to stay alive on Mars. The basis of the movie.",
        "price": 0,
        "title": "THE MARTIAN",
        "author": "Andy Weir",
        "contributor": "by Andy Weir",
        "contributor_note": "",
        "book_image": "http://du.ec2.nytimes.com.s3.amazonaws.com/prd/books/9780804139038.jpg",
        "amazon_product_url": "http://www.amazon.com/The-Martian-Novel-Andy-Weir-ebook/dp/B00EMXBDMA?tag=thenewyorktim-20",
        "age_group": "",
        "book_review_link": "",
        "first_chapter_link": "",
        "sunday_review_link": "",
        "article_chapter_link": "",
        "isbns": [
          {
            "isbn10": "0804139024",
            "isbn13": "9780804139021"
          }
        ]
      }
    ],
    "corrections": []
  }
}
```


# GET Lists-Full-Overview-Format

Get all books for all the Best Sellers lists for specified date.

```csharp
GETListsFullOverviewFormatAsync(
    string publishedDate = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedDate` | `string` | Query, Optional | YYYY-MM-DD<br><br>The best-seller list publication date.<br>You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.<br><br>If you do not include a published date, the current week's best sellers lists will be returned.<br>**Constraints**: *Pattern*: `^\d{4}-\d{2}-\d{2}$` |

## Response Type

[`Task<Models.OverviewResponse>`](../../doc/models/overview-response.md)

## Example Usage

```csharp
try
{
    OverviewResponse result = await aPIController.GETListsFullOverviewFormatAsync(null);
}
catch (ApiException e){};
```


# GET Lists-Overview-Format

Get top 5 books for all the Best Sellers lists for specified date.

```csharp
GETListsOverviewFormatAsync(
    string publishedDate = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedDate` | `string` | Query, Optional | YYYY-MM-DD<br><br>The best-seller list publication date.<br>You do not have to specify the exact date the list was published. The service will search forward (into the future) for the closest publication date to the date you specify. For example, a request for lists/overview/2013-05-22 will retrieve the list that was published on 05-26.<br><br>If you do not include a published date, the current week's best sellers lists will be returned.<br>**Constraints**: *Pattern*: `^\d{4}-\d{2}-\d{2}$` |

## Response Type

[`Task<Models.OverviewResponse>`](../../doc/models/overview-response.md)

## Example Usage

```csharp
try
{
    OverviewResponse result = await aPIController.GETListsOverviewFormatAsync(null);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 210,
  "results": {
    "bestsellers_date": "2016-03-05",
    "published_date": "2016-03-20",
    "lists": [
      {
        "list_id": 704,
        "list_name": "Combined Print and E-Book Fiction",
        "display_name": "Combined Print & E-Book Fiction",
        "updated": "WEEKLY",
        "list_image": "http://du.ec2.nytimes.com.s3.amazonaws.com/prd/books/9780399175954.jpg",
        "books": [
          {
            "age_group": "",
            "author": "Clive Cussler and Justin Scott",
            "contributor": "by Clive Cussler and Justin Scott",
            "contributor_note": "",
            "created_date": "2016-03-10 12:00:22",
            "description": "In the ninth book in this series, set in 1906, the New York detective Isaac Bell contends with a crime boss passing as a respectable businessman and a tycoon’s plot against President Theodore Roosevelt.",
            "price": 0,
            "primary_isbn13": "9780698406421",
            "primary_isbn10": "0698406427",
            "publisher": "Putnam",
            "rank": 1,
            "title": "THE GANGSTER",
            "updated_date": "2016-03-10 17:00:21"
          }
        ]
      }
    ]
  }
}
```


# GET Lists-Names-Format

Get Best Sellers list names.

```csharp
GETListsNamesFormatAsync()
```

## Response Type

[`Task<Models.GETListsNamesFormatResponse>`](../../doc/models/get-lists-names-format-response.md)

## Example Usage

```csharp
try
{
    GETListsNamesFormatResponse result = await aPIController.GETListsNamesFormatAsync();
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 53,
  "results": [
    {
      "list_name": "Combined Print and E-Book Fiction",
      "display_name": "Combined Print & E-Book Fiction",
      "list_name_encoded": "combined-print-and-e-book-fiction",
      "oldest_published_date": "2011-02-13",
      "newest_published_date": "2016-03-20",
      "updated": "WEEKLY"
    }
  ]
}
```


# GET Lists-Best-Sellers-History-Json

Get Best Sellers list history.

```csharp
GETListsBestSellersHistoryJsonAsync(
    string ageGroup = null,
    string author = null,
    string contributor = null,
    string isbn = null,
    int? offset = null,
    string price = null,
    string publisher = null,
    string title = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ageGroup` | `string` | Query, Optional | The target age group for the best seller. |
| `author` | `string` | Query, Optional | The author of the best seller. The author field does not include additional contributors (see Data Structure for more details about the author and contributor fields).<br><br>When searching the author field, you can specify any combination of first, middle and last names.<br><br>When sort-by is set to author, the results will be sorted by author's first name. |
| `contributor` | `string` | Query, Optional | The author of the best seller, as well as other contributors such as the illustrator (to search or sort by author name only, use author instead).<br><br>When searching, you can specify any combination of first, middle and last names of any of the contributors.<br><br>When sort-by is set to contributor, the results will be sorted by the first name of the first contributor listed. |
| `isbn` | `string` | Query, Optional | International Standard Book Number, 10 or 13 digits<br><br>A best seller may have both 10-digit and 13-digit ISBNs, and may have multiple ISBNs of each type. To search on multiple ISBNs, separate the ISBNs with semicolons (example: 9780446579933;0061374229). |
| `offset` | `int?` | Query, Optional | Sets the starting point of the result set (0, 20, ...).  Used to paginate thru results if there are more than 20. Defaults to 0. The num_results field indicates how many results there are total.<br>**Constraints**: *Multiple Of*: `20` |
| `price` | `string` | Query, Optional | The publisher's list price of the best seller, including decimal point. |
| `publisher` | `string` | Query, Optional | The standardized name of the publisher |
| `title` | `string` | Query, Optional | The title of the best seller<br><br>When searching, you can specify a portion of a title or a full title. |

## Response Type

[`Task<Models.GETListsBestSellersHistoryJsonResponse>`](../../doc/models/get-lists-best-sellers-history-json-response.md)

## Example Usage

```csharp
try
{
    GETListsBestSellersHistoryJsonResponse result = await aPIController.GETListsBestSellersHistoryJsonAsync(null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 28970,
  "results": [
    {
      "title": "#GIRLBOSS",
      "description": "An online fashion retailer traces her path to success.",
      "contributor": "by Sophia Amoruso",
      "author": "Sophia Amoruso",
      "contributor_note": "",
      "price": 0,
      "age_group": "",
      "publisher": "Portfolio/Penguin/Putnam",
      "isbns": [
        {
          "isbn10": "039916927X",
          "isbn13": "9780399169274"
        }
      ],
      "ranks_history": [
        {
          "primary_isbn10": "1591847931",
          "primary_isbn13": "9781591847939",
          "rank": 8,
          "list_name": "Business Books",
          "display_name": "Business",
          "published_date": "2016-03-13",
          "bestsellers_date": "2016-02-27",
          "weeks_on_list": 0,
          "ranks_last_week": null,
          "asterisk": 0,
          "dagger": 0
        }
      ],
      "reviews": [
        {
          "book_review_link": "",
          "first_chapter_link": "",
          "sunday_review_link": "",
          "article_chapter_link": ""
        }
      ]
    }
  ]
}
```


# GET Reviews-Format

Get book reviews.

```csharp
GETReviewsFormatAsync(
    int? isbn = null,
    string title = null,
    string author = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `isbn` | `int?` | Query, Optional | Searching by ISBN is the recommended method. You can enter 10- or 13-digit ISBNs. |
| `title` | `string` | Query, Optional | You’ll need to enter the full title of the book. Spaces in the title will be converted into the characters %20. |
| `author` | `string` | Query, Optional | You’ll need to enter the author’s first and last name, separated by a space. This space will be converted into the characters %20. |

## Response Type

[`Task<Models.GETReviewsFormatResponse>`](../../doc/models/get-reviews-format-response.md)

## Example Usage

```csharp
try
{
    GETReviewsFormatResponse result = await aPIController.GETReviewsFormatAsync(null, null, null);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "copyright": "Copyright (c) 2019 The New York Times Company.  All Rights Reserved.",
  "num_results": 2,
  "results": [
    {
      "url": "http://www.nytimes.com/2011/11/10/books/1q84-by-haruki-murakami-review.html",
      "publication_dt": "2011-11-10",
      "byline": "JANET MASLIN",
      "book_title": "1Q84",
      "book_author": "Haruki Murakami",
      "summary": "In “1Q84,” the Japanese novelist Haruki Murakami writes about characters in a Tokyo with two moons.",
      "isbn13": [
        "9780307476463"
      ]
    }
  ]
}
```

