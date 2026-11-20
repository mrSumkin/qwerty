using System;
using System.Runtime.Serialization;

// Token: 0x0200117B RID: 4475
[eiz("EXDF")]
[Serializable]
public sealed class c00 : ISerializable
{
	// Token: 0x06005FA1 RID: 24481 RVA: 0x0029AD4C File Offset: 0x00298F4C
	private c00(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("EXDF:LD", typeof(blv)) as blv);
		this.b = (A_0.GetValue("EXDF:A", typeof(cci)) as cci);
		this.c = A_0.GetDouble("EXDF:NPD");
		this.d = A_0.GetSingle("EXDF:R");
		this.e = A_0.GetString("EXDF:SFX");
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x0029ADE0 File Offset: 0x00298FE0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("EXDF:LD", this.a);
		info.AddValue("EXDF:A", this.b);
		info.AddValue("EXDF:NPD", this.c);
		info.AddValue("EXDF:R", this.d);
		info.AddValue("EXDF:SFX", this.e);
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x0029AE44 File Offset: 0x00299044
	public c00()
	{
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x0029AE5C File Offset: 0x0029905C
	public awb a(ak1 A_0)
	{
		awb awb = new awb(A_0, this.b, (this.a != null) ? new ae8?(this.a.a.Light) : null, this.d, this.e, null, false);
		awb.b(this.c);
		if (this.a != null && this.a.a != null)
		{
			awb.c(this.a.b);
			awb.b(this.a.c);
			awb.a(this.a.d);
		}
		return awb;
	}

	// Token: 0x04002802 RID: 10242
	public blv a = new blv();

	// Token: 0x04002803 RID: 10243
	public cci b;

	// Token: 0x04002804 RID: 10244
	public double c;

	// Token: 0x04002805 RID: 10245
	public float d;

	// Token: 0x04002806 RID: 10246
	public string e;
}
