# XmlMappingSample
PoC project to create a dynamic method for mapping xml to its class type without deserializing it directly. This cam up because of a vendor I had to interface with which changed their xml structure without notice and did not provide an updated xsd. Generally it came down to little issues like required elements or adding/removing namespaces which tripped up the generated classes (via xsd.exe or a 3rd party tool). It's not a preferred method, but in those rare cases you need an alternative here ya go. It includes 2 possible ways to do it using Newtonsoft.