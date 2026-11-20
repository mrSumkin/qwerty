using System;
using System.Runtime.Serialization;

// Token: 0x02001B48 RID: 6984
[eiz("ELOEQC")]
[Serializable]
public sealed class cqk : dth, ISerializable
{
	// Token: 0x0600970A RID: 38666 RVA: 0x003AFD24 File Offset: 0x003ADF24
	private cqk(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("ELOEQC:M");
	}

	// Token: 0x0600970B RID: 38667 RVA: 0x003AFD40 File Offset: 0x003ADF40
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("ELOEQC:M", this.a);
	}

	// Token: 0x0600970C RID: 38668 RVA: 0x003AFD54 File Offset: 0x003ADF54
	public double a()
	{
		return this.a;
	}

	// Token: 0x0600970D RID: 38669 RVA: 0x003AFD5C File Offset: 0x003ADF5C
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600970E RID: 38670 RVA: 0x003AFD68 File Offset: 0x003ADF68
	public cqk()
	{
	}

	// Token: 0x0600970F RID: 38671 RVA: 0x003AFD70 File Offset: 0x003ADF70
	public cqk(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009710 RID: 38672 RVA: 0x003AFD80 File Offset: 0x003ADF80
	public bool jh(object A_0)
	{
		ll ll = A_0 as ll;
		return ll != null && ll.a() != null && ll.a().Defense.aj() <= this.a;
	}

	// Token: 0x06009711 RID: 38673 RVA: 0x003AFDC4 File Offset: 0x003ADFC4
	public string ji()
	{
		return string.Format("Работает только если штраф брони не выше {0}%", (int)(this.a * 100.0));
	}

	// Token: 0x04003A1A RID: 14874
	private double a;
}
