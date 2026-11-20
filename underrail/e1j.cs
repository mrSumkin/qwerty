using System;
using System.Runtime.Serialization;

// Token: 0x020006AF RID: 1711
[eiz("FRC")]
[Serializable]
public class e1j : ISerializable
{
	// Token: 0x06002C57 RID: 11351 RVA: 0x000FDD34 File Offset: 0x000FBF34
	protected e1j(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("FRC:I");
		this.b = A_0.GetDouble("FRC:C");
		this.c = (A_0.GetValue("FRC:P", typeof(double?)) as double?);
		this.d = (A_0.GetValue("FRC:F", typeof(double?)) as double?);
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x000FDDB4 File Offset: 0x000FBFB4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FRC:I", this.a);
		info.AddValue("FRC:C", this.b);
		info.AddValue("FRC:P", this.c);
		info.AddValue("FRC:F", this.d);
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x000FDE10 File Offset: 0x000FC010
	public string d()
	{
		return this.a;
	}

	// Token: 0x06002C5A RID: 11354 RVA: 0x000FDE18 File Offset: 0x000FC018
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x000FDE24 File Offset: 0x000FC024
	public double c()
	{
		return this.b;
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x000FDE2C File Offset: 0x000FC02C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x000FDE38 File Offset: 0x000FC038
	public double? a()
	{
		return this.c;
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x000FDE40 File Offset: 0x000FC040
	public void b(double? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x000FDE4C File Offset: 0x000FC04C
	public double? b()
	{
		return this.d;
	}

	// Token: 0x06002C60 RID: 11360 RVA: 0x000FDE54 File Offset: 0x000FC054
	public void a(double? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002C61 RID: 11361 RVA: 0x000FDE60 File Offset: 0x000FC060
	public e1j()
	{
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x000FDE6C File Offset: 0x000FC06C
	public double c(double? A_0 = null)
	{
		if (A_0 == null)
		{
			return this.b;
		}
		double num = A_0.Value;
		if (this.c != null)
		{
			num *= this.c.Value;
		}
		if (this.d != null)
		{
			num += this.d.Value;
		}
		return num;
	}

	// Token: 0x0400192B RID: 6443
	private string a;

	// Token: 0x0400192C RID: 6444
	private double b;

	// Token: 0x0400192D RID: 6445
	private double? c;

	// Token: 0x0400192E RID: 6446
	private double? d;
}
