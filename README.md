# XmlMappingSample
PoC project to create a dynamic method for mapping xml to its class type without deserializing it directly. This need arose because of a vendor, I had to interface with, which changed their xml structure without notice that conflicted with their xsd. We generate the xsd into classes using either xsd.exe or a 3rd party tool (Depending on how many xsd's are involved).

The issues we faced generally came down to the following after deserializing the xml:
1. Adding new elements (We have a way to ignore this part)
2. Not providing elements which are required in the xsd
3. Adding or excluding namespace references

This method is not preferred, but if you encounter unpredictable changes to the data you receive this might help. I wanted to use a different method than xpath (I ultimately wanted to use dynamic, but started a more traditional way) so you have both paths I created.

The data I'm using came from a gov spec which has a ton of xsd's and associated namespaces (The xsd's aren't included because generating the classes from the xml was sufficient). I chose this data sample to identify it can handle the more complex cases during the mapping process. The nibrs data sample included is safe for public viewing based on the the announcement here: https://www.fbi.gov/news/stories/five-things-to-know-about-nibrs-112520
