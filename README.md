# Задания для самостоятельной работы

1. Напишите программу с классом, в котором есть закрытое символь­ное поле и три открытых метода. Один из методов позволяет присво­ить значение полю. Еще один метод при вызове возвращает результатом код символа. Третий метод позволяет вывести в консольное окно символ (значение поля) и его код.

2. Напишите программу с классом, у которого есть два символьных поля и метод. Он не возвращает результат, и у него нет аргументов. При вы­зове метод выводит в консольное окно все символы из кодовой табли­цы, которые находятся "между" символами, являющимися значениями полей объекта (из которого вызывается метод). Например, если полям объекта присвоены значения ' А ' и ' D ' , то при вызове метода в консоль­ное окно должны выводиться все символы от ' А ' до ' D ' включительно.

3. Напишите программу с классом, у которого есть два целочисленных поля. В классе должны быть описаны конструкторы, позволяющие соз­давать объекты без передачи аргументов, с передачей одного аргумента и с передачей двух аргументов.

4. Напишите программу с классом, у которого есть символьное и цело­численное поле. В классе должны быть описаны версии конструктора с двумя аргументами (целое число и символ - определяют значения полей), а также с одним аргументом типа douЬle. В последнем случае действительная часть аргумента определяет код символа (значение сим­вольного поля), а дробная часть (с учетом десятых и сотых) определяет значение целочисленного поля. Например, если аргументом передается число 65,1267, то значением символьного поля будет символ 'А' с ко­дом 65, а целочисленное поле получит значение 12 (в дробной части учитываются только десятые и сотые).

5. Напишите программу с классом, у которого есть закрытое целочис­ленное поле. Значение полю присваивается с помощью открытого мето­да. Методу аргументом может передаваться целое число, а также метод может вызываться без аргументов. Если метод вызывается без аргумен­тов, то поле получает нулевое значение. Если метод вызывается с цело­численным аргументом, то это значение присваивается полю. Однако если переданное аргументом методу значение превышает 1ОО , то значе­нием полю присваивается число 1ОО. Предусмотрите в классе конструк­тор, который работает по тому же принципу, что и метод для присваи­вания значения полю. Также в классе должен быть метод, позволяющий проверить значение поля.

6. Напишите программу с классом, в котором есть два закрытых цело­численных поля (назовем их max и min). Значение поля max не может быть меньше значения поля min. Значения полям присваиваются с по­мощью открытого метода. Метод может вызываться с одним или двумя целочисленными аргументами. При вызове метода значения полям при­сваиваются так: сравниваются текущие значения полей и значения аргу­мента или аргументов, переданных методу. Самое большое из значений присваивается полю max, а самое маленькое из значений присваивает­ся полю min . Предусмотрите конструктор, который работает по тому же принципу, что и метод для присваивания значений полям. В классе так­ же должен быть метод, отображающий в консольном окне значения по­лей объекта.

7. Напишите программу с классом, в котором есть два поля: символьное и текстовое. В классе должен быть перегруженный метод для присваива­ния значений полям. Если метод вызывается с символьным аргументом, то соответствующее значение присваивается символьному полю. Если метод вызывается с текстовым аргументом, то он определяет значение текстового поля. Методу аргументом также может передаваться сим­вольный массив. Если массив состоит из одного элемента, то он опре­деляет значение символьного поля. В противном случае (если в массиве больше одного элемента) из символов массива формируется текстовая строка и присваивается значением текстовому полю.

8. Напишите программу с классом, в котором есть закрытое статическое целочисленное поле с начальным нулевым значением. В классе должен быть описан статический метод, при вызове которого отображается те­кущее значение статического поля, после чего значение поля увеличи­вается на единицу.

9. Напишите программу с классом, в котором есть статические методы, которым можно передавать произвольное количество целочисленных аргументов (или целочисленный массив). Методы, на основании пере­данных аргументов или массива, позволяют вычислить: наибольшее зна­чение, наименьшее значение, а также среднее значение из набора чисел.

10. Напишите программу со статическим методом для вычисления косинуса. Используйте формулу
cos(x) = 1 - (x^2)/2! + (x^4)/4! + (-1)^n * (x^2n)/(2n)!
В классе также должны быть статические методы для вычисления гиперболического синуса
sh(x) = x + (x^3)/3! + (x^5)/5! + (x^(2n+1))/(2n+1)!
и гиперболического косинуса
ch(x) = 1 + (x^2)/2! + (x^4)/4! + (x^2n)/(2n)!