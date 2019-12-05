# Xrm.ReportUtility
1)У всех наследников ReportServiceTransformerBase в методе TransformData 
сначала вызывается TransformData у dataTransformer, а затем выполняются какие-то преобразования над результатом.
Для этого существует паттерн декоратор, под него отрефакторена эта часть кода(в ReportServiceTransformerBase добавлен метод AfterTransform).

2)Для составления шаблона таблицы, которая печатается в методе PrintReport, реализован классический билдер PrintTemplateBuilder. Работа с условиями, при которых собирается та или иная часть шаблона, делегирована PrintReportDirector. 
При этом выполнена хотелка #3.(Исключение столбцов по-умолчанию) Код - в папке PrintReport

3)Выполнены хотелки #1 и #2 с помощью метода ValidateArgs класса ArgParser.

4)Cтатический фабричный метод CreateTransformer обнаружен в классе DataTransformerCreator.

5)Шаблонный метод CreateReport обнаружен в классе ReportServiceBase(CreateReport использует внутри себя абстрактный метод GetDataRows, реализуемый наследниками)

6)Статический фабричный метод GetReportService обнаружен в классе Program
