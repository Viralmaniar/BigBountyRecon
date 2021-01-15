# BigBountyRecon
BigBountyRecon tool utilises 58 different techniques to expediate the process of initial reconnaissance on the target organisation. Reconnaissance is the most important step in any penetration testing or a bug hunting process. It provides an attacker some priliminary knowledge on a target organisation. Furthermore, it will be useful to gain insights into controls in place as well as security matuarity of a target organisation.

Often times, 

![image](https://user-images.githubusercontent.com/3501170/104112108-d9145c00-533e-11eb-85be-cb1d33fc9362.png)

# Techniques

1. Directory Listing: Finding open directories using Google Dork on your target organisation helps one to understand the directory structure on the webserver. It may reveal sensitive information or it may lead to information disclosure.

2. Configuration Files: Often times configuration files contains sensitive information such as hardcoded passwords, sensitive drive locations or API tokens which can help you gain privilege access to the internal resources.

3. Database Files: 

4. WordPress: 

5. Log Files:

6. Backup and Old Files:

7. Login Pages:

8. SQL Errors:

9. Apache Config Files:

10. Robots.txt File:

11. DomainEye:

12. Publicly Exposed Documents:

13. phpinfo():

14. Finding Backdoors:

15. Install/Setup Files:

16. Open Redirects:

17. Apache Struts RCE:

18. 3rd Party Exposure:

19. Check Security Headers:

20. GitLab:

21. Find Pastebin Entries:

22. Employees on LINKEDIN:

23. .HTACCESS / Sensitive Files:

24. Find Subdomains:

25: Find Sub-Subdomains:

26: Find WordPress related expsoure:

27: BitBucket & Atlassian:

28: PassiveTotal:

29: Stackoverflow:

30: Find WordPress related expsore using Wayback Machine:

31: GitHub:

32: OpenBugBounty:

33. Reddit:

34. CrossDomain.xml:

35. ThreatCrowd:

36. .git Folder:

37. YouTube:

38. Digital Ocean Spaces:

39. .SWF File (Google):

40. .SWF File (Yandex):

41. .SWF File (Wayback Machine):

42. WayBack Machine:

43. Reverse IP Lookup:

44. Traefik:

45. Cloud Storage and Buckets:

46. s3 Buckets:

47. PublicWWW:

48. Censys (IPv4, Domains & Certs):

49. Shodan:

50. SharePoint RCE: 

51. API Endpoints:

52. Gist Searches:

53. CT Logs:

54. Password Leak:

55. What CMS:



# Dorking operators across Google, DuckDuckGo, Yahoo and Bing

Here is a table with possible dorks for various search engines.

| Dork                                                        	| Description                                                                                                                                                                                                                                                 	| Google 	| DuckDuckGo 	| Yahoo 	| Bing 	|
|-------------------------------------------------------------	|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	|--------	|------------	|-------	|------	|
| cache:[url]                                                 	| Shows the version of the web page from the search engine’s cache.                                                                                                                                                                                           	| ✓      	|            	|       	|      	|
| related:[url]                                               	| Finds web pages that are similar to the specified web page.                                                                                                                                                                                                 	| ✓      	|            	|       	|      	|
| info:[url]                                                  	| Presents some information that Google has about a web page, including similar pages, the cached version of the page, and sites linking to the page.                                                                                                         	| ✓      	|            	|       	|      	|
| site:[url]                                                  	| Finds pages only within a particular domain and all its subdomains.                                                                                                                                                                                         	| ✓      	| ✓          	| ✓     	| ✓    	|
| intitle:[text] or allintitle:[text]                         	| Finds pages that include a specific keyword as part of the indexed title tag. You must include a space between the colon and the query for the operator to work in Bing.                                                                                    	| ✓      	| ✓          	| ✓     	| ✓    	|
| allinurl:[text]                                             	| Finds pages that include a specific keyword as part of their indexed URLs.                                                                                                                                                                                  	| ✓      	|            	|       	|      	|
| meta:[text]                                                 	| Finds pages that contain the specific keyword in the meta tags.                                                                                                                                                                                             	| ✓      	|            	|       	|      	|
| filetype:[file extension]                                   	| Searches for specific file types.                                                                                                                                                                                                                           	| ✓      	| ✓          	| ✓     	| ✓    	|
| intext:[text], allintext:[text], inbody:[text]              	| Searches text of page. For Bing and Yahoo the query is inbody:[text]. For DuckDuckGo the query is intext:[text]. For Google either intext:[text] or allintext:[text] can be used.                                                                           	| ✓      	| ✓          	| ✓     	| ✓    	|
| inanchor:[text]                                             	| Search link anchor text                                                                                                                                                                                                                                     	| ✓      	|            	|       	|      	|
| location:[iso code] or loc:[iso code], region:[region code] 	| Search for specific region. For Bing use location:[iso code] or loc:[iso code] and for DuckDuckGo use region:[iso code].An iso location code is a short code for a country for example, Egypt is eg and USA is us. https://en.wikipedia.org/wiki/ISO_3166-1 	| ✓      	| ✓          	|       	|      	|
| contains:[text]                                             	| Identifies sites that contain links to filetypes specified (i.e. contains:pdf)                                                                                                                                                                              	| ✓      	|            	|       	|      	|
| altloc:[iso code]                                           	| Searches for location in addition to one specified by language of site (i.e. pt-us or en-us)                                                                                                                                                                	| ✓      	|            	|       	|      	|
| feed:[feed type, i.e. rss]                                  	| Find RSS feed related to search term                                                                                                                                                                                                                        	| ✓      	| ✓          	| ✓     	|      	|
| hasfeed:[url]                                               	| Finds webpages that contain both the term or terms for which you are querying and one or more RSS or Atom feeds.                                                                                                                                            	| ✓      	| ✓          	|       	|      	|
| ip:[ip address]                                             	| Find sites hosted by a specific ip address                                                                                                                                                                                                                  	| ✓      	| ✓          	|       	|      	|
| language:[language code]                                    	| Returns websites that match the search term in a specified language                                                                                                                                                                                         	| ✓      	| ✓          	|       	|      	|
| book:[title]                                                	| Searches for book titles related to keywords                                                                                                                                                                                                                	| ✓      	|            	|       	|      	|
| maps:[location]                                             	| Searches for maps related to keywords                                                                                                                                                                                                                       	| ✓      	|            	|       	|      	|
| linkfromdomain:[url]                                        	| Shows websites whose links are mentioned in the specified url (with errors)                                                                                                                                                                                 	| ✓      	|            	|       	|      	|
