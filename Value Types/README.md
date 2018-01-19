* Simple Types

|                    |       |       |     |      |
|--------------------|-------|-------|-----|------|
|**Signed integral:** | `sbyte` | `short` | `int` | `long` |
|**Unsigned integral:**|`byte`|`ushort`|`uint`|`ulong`|
|**Unicode characters:**|`char`|
|**IEEE floating point:**|`float`|`double`|
|**High-precision decimal:**|`decimal`|
|**Boolean:**|`bool`|

---

|                    |       |     
|--------------------|------|
|**Enum types**|`enum E {...}`|

---

|                    |       |     
|--------------------|------|
|**Struct types**|`struct S {...}`|

---

|                    |       |     
|--------------------|------|
|**Nullable value types**|`null`|

---

* Reference types

| Class types        |       |  
|--------------------|-------|
|**Ultimate base class of all other types:**|`object`|
|**Unicode strings:**|`string`|
|**User-defined types of the form**|`class C {...}`|

| Interface types        |       |  
|--------------------|-------|
|**User-defined types of the form**|`interface I {...}`|

| Array  types        |       |  |
|--------------------|-------|--|
|**Single- and multi-dimensional, for example,**|`int[]`|`int[,]`|

| Delegate   types        |       |  
|--------------------|-------|
|**User-defined types of the form**|`delegate int D(...)`|

---
* Signed Integral

|   |       |  
|--------------------|-------|
|`sbyte`:|8 bits, range from -128 - 127|
|`short`:|16 bits, range from -32,768 - 32,767|
|`int`:|32 bits, range from -2,147,483,648 - 2,147,483,647|
|`long`:|64 bits, range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|

* Unsigned Integral

|   |       |  
|--------------------|-------|
|`byte`:|8 bits, range from 0 - 255|
|`ushort`:|16 bits, range from 0 - 65,535|
|`uint`:|32 bits, range from 0 - 4,294,967,295|
|`ulong`:|64 bits, range from 0 - 18,446,744,073,709,551,615|

* Floating point

|   |       |  
|--------------------|-------|
|`float`:|32 bits, range from 1.5 × 10^{−45} - 3.4 × 10^38, 7-digit precision|
|`double`:|64 bits, range from 5.0 × 10^−324 - 1.7 × 10^308, 15-digit precision|
---

![equation](http://www.sciweavers.org/tex2img.php?eq=32%20bits%2C%20range%20from%201.5%20%C3%97%2010%5E%7B%E2%88%9245%7D%20%20-%203.4%20%C3%97%2010%5E%7B38%7D%2C%207-digit%20precision%20%0A%0A&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)
