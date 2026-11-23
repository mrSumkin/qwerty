using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A8 RID: 4264
[eiz("SGJZ")]
[Serializable]
public sealed class co3 : cze
{
	// Token: 0x06005972 RID: 22898 RVA: 0x0026A52C File Offset: 0x0026872C
	private co3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SGJZ:C");
		this.b = A_0.GetDouble("SGJZ:A");
		this.c = (A_0.GetValue("SGJZ:T", typeof(edx)) as edx);
		this.d = A_0.GetString("SGJZ:O");
	}

	// Token: 0x06005973 RID: 22899 RVA: 0x0026A594 File Offset: 0x00268794
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGJZ:C", this.a);
		info.AddValue("SGJZ:A", this.b);
		info.AddValue("SGJZ:T", this.c);
		info.AddValue("SGJZ:O", this.d);
	}

	// Token: 0x06005974 RID: 22900 RVA: 0x0026A5F0 File Offset: 0x002687F0
	public string d()
	{
		return this.a;
	}

	// Token: 0x06005975 RID: 22901 RVA: 0x0026A5F8 File Offset: 0x002687F8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005976 RID: 22902 RVA: 0x0026A604 File Offset: 0x00268804
	public double c()
	{
		return this.b;
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x0026A60C File Offset: 0x0026880C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005978 RID: 22904 RVA: 0x0026A618 File Offset: 0x00268818
	public edx b()
	{
		return this.c;
	}

	// Token: 0x06005979 RID: 22905 RVA: 0x0026A620 File Offset: 0x00268820
	public void a(edx A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600597A RID: 22906 RVA: 0x0026A62C File Offset: 0x0026882C
	public string a()
	{
		return this.d;
	}

	// Token: 0x0600597B RID: 22907 RVA: 0x0026A634 File Offset: 0x00268834
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600597C RID: 22908 RVA: 0x0026A640 File Offset: 0x00268840
	public co3()
	{
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x0026A648 File Offset: 0x00268848
	public co3(string A_0, double A_1, ak1 A_2, string A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = new edx(A_2);
		this.d = A_3;
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x0026A674 File Offset: 0x00268874
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.c != null && this.c.ao() != null)
		{
			bpv.a(this.a, this.b, this.c.ao(), this.d, false, false, new double?(1000.0));
		}
	}

	// Token: 0x040023F0 RID: 9200
	private new string a;

	// Token: 0x040023F1 RID: 9201
	private double b;

	// Token: 0x040023F2 RID: 9202
	private edx c;

	// Token: 0x040023F3 RID: 9203
	private string d;
}
