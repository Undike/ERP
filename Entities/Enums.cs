namespace ERP.Entities;

public enum OrderStatus //! переделать под класс
{
   Pending,
   Processing,
   Shipped,
   Delivered,
   Cancelled
}

public enum PrintingMethod //! переделать под класс
{
   MATAN,
   RESIN,
   ROLAND
}

public enum EmployeeRole //! переделать под класс
{
   SalesManager,
   ProductionManager,
   Designer,
   Operator
}
[Flags]
public enum PlotterOperationType
{
   none = 0,
   CounterCut = 1,
   Formating = 2,
   FieldAlignment = 4
}


public enum LaminationOperationType
{
   PaperTranfer,
   FoilTransfer,
   OverLamination,
   UnderLamination
}

public enum PolyurethaneHardness
{
   Soft,
   Hard
}

public enum GuillotineCutType
{
   Formatki,
   Uzytki
}

public enum WeedingComplexity
{
   Low,
   Medium,
   Hard
}