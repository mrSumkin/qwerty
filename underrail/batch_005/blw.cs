using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001117 RID: 4375
[eiz("S9")]
[Serializable]
public sealed class blw : cze
{
	// Token: 0x06005D36 RID: 23862 RVA: 0x0027B05C File Offset: 0x0027925C
	private blw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("S9:MN");
		this.b = A_0.GetSingle("S9:MX");
		this.c = A_0.GetDouble("S9:C");
		this.d = A_0.GetString("S9:N");
	}

	// Token: 0x06005D37 RID: 23863 RVA: 0x0027B0B8 File Offset: 0x002792B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S9:MN", this.a);
		info.AddValue("S9:MX", this.b);
		info.AddValue("S9:N", this.d);
		info.AddValue("S9:C", this.c);
	}

	// Token: 0x06005D38 RID: 23864 RVA: 0x0027B114 File Offset: 0x00279314
	public float d()
	{
		return this.a;
	}

	// Token: 0x06005D39 RID: 23865 RVA: 0x0027B11C File Offset: 0x0027931C
	public void b(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D3A RID: 23866 RVA: 0x0027B128 File Offset: 0x00279328
	public float a()
	{
		return this.b;
	}

	// Token: 0x06005D3B RID: 23867 RVA: 0x0027B130 File Offset: 0x00279330
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D3C RID: 23868 RVA: 0x0027B13C File Offset: 0x0027933C
	public double b()
	{
		return this.c;
	}

	// Token: 0x06005D3D RID: 23869 RVA: 0x0027B144 File Offset: 0x00279344
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D3E RID: 23870 RVA: 0x0027B150 File Offset: 0x00279350
	public string c()
	{
		return this.d;
	}

	// Token: 0x06005D3F RID: 23871 RVA: 0x0027B158 File Offset: 0x00279358
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005D40 RID: 23872 RVA: 0x0027B164 File Offset: 0x00279364
	public blw()
	{
	}

	// Token: 0x06005D41 RID: 23873 RVA: 0x0027B170 File Offset: 0x00279370
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			c1a c1a;
			if (A_0 != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null)
			{
				c1a = A_1.Zone;
			}
			else
			{
				c1a = null;
			}
			if (c1a != null)
			{
				ah7 ah = c1a.i(this.d);
				if (ah != null)
				{
					e1o a_ = new e1o(ah, this.a, this.b, this.c);
					c1a.ActionManager.g9(a_, atp.a);
				}
			}
		}
	}

	// Token: 0x04002529 RID: 9513
	private new float a;

	// Token: 0x0400252A RID: 9514
	private float b;

	// Token: 0x0400252B RID: 9515
	private double c;

	// Token: 0x0400252C RID: 9516
	private string d;
}
