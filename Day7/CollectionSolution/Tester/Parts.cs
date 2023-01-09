namespace Garage;

public class Parts
{
    public string PartName{get;set;}

    public  int PartId{get;set;}

    public override string ToString()
    {
        return "ID: "+PartId + " Name: "+PartName;

    }

    public override bool Equals(object obj)
    {
        if(obj==null) return false;
        Parts objAsPart = obj as Parts;
        if(objAsPart==null) return false;
        else return Equals(objAsPart);
    }

    public bool Equals(Parts other)
    {
        if(other==null)return false;
        return (this.PartId.Equals(other.PartId));
    }

    public override int GetHashCode()
    {
        return PartId;
    }
}