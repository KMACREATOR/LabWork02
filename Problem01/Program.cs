using System;

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Некий ученик как-то учится.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Некий ученик как-то читает.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Некий ученик как-то пишет.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Некий ученик как-то отдыхает");
    }
}

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится не покладая рук.");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает весь материал, и даже больше.");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет аккуратно.");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник спокойно отдыхает после усердной работы");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист занимается со старанием");
    }

    public override void Read()
    {
        Console.WriteLine("Хорошист читает внимательно.");
    }

    public override void Write()
    {
        Console.WriteLine("Хорошист пишет прилично.");
    }

    public override void Relax()
    {
        Console.WriteLine("Хорошист тоже заслуженно отдыхает.");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Двоечник учится спустя рукава.");
    }

    public override void Read()
    {
        Console.WriteLine("Двоечник ничего не читает.");
    }

    public override void Write()
    {
        Console.WriteLine("Двоечник пишет неаккуратно и неразборчиво.");
    }

    public override void Relax()
    {
        Console.WriteLine("Двоечник отдыхает без повода.");
    }
}


public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 4)
        {
            throw new ArgumentException("Учеников должно быть не меньше 2 и не больше 4");
        }
        this.pupils = pupils;
    }

    public void PupilsRoutine()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pupil HardWorker = new ExcellentPupil();
        Pupil GoodFella = new GoodPupil();
        Pupil Slacker = new BadPupil();
        Pupil AcademicBeast = new ExcellentPupil();

        ClassRoom classRoom = new ClassRoom(HardWorker, GoodFella, Slacker, AcademicBeast);
        classRoom.PupilsRoutine();
    }
}

