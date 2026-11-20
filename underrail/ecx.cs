using System;
using System.Runtime.Serialization;

// Token: 0x020007E2 RID: 2018
[eiz("CCGCT1")]
[Serializable]
public sealed class ecx : cca, ISerializable
{
	// Token: 0x0600328E RID: 12942 RVA: 0x0013A2C4 File Offset: 0x001384C4
	private ecx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CCGCT1:T1");
			this.b = A_0.GetString("CCGCT1:T2");
			this.c = (Guid?)A_0.GetValue("CCGCT1:S", typeof(Guid?));
			this.d = A_0.GetBoolean("CCGCT1:IT");
			return;
		}
		if (base.GetType() == typeof(d9s))
		{
			this.a = A_0.GetString("_Text1");
			this.b = A_0.GetString("_Text2");
			this.c = (Guid?)A_0.GetValue("_Speaker", typeof(Guid?));
			try
			{
				this.d = A_0.GetBoolean("_InterruptTalking");
				return;
			}
			catch
			{
				return;
			}
		}
		this.a = A_0.GetString("LocaleNarrationTrigger+_Text1");
		this.b = A_0.GetString("LocaleNarrationTrigger+_Text2");
		this.c = (Guid?)A_0.GetValue("LocaleNarrationTrigger+_Speaker", typeof(Guid?));
		try
		{
			this.d = A_0.GetBoolean("LocaleNarrationTrigger+_InterruptTalking");
		}
		catch
		{
		}
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x0013A430 File Offset: 0x00138630
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCGCT1:T1", this.a);
		info.AddValue("CCGCT1:T2", this.b);
		info.AddValue("CCGCT1:S", this.c);
		info.AddValue("CCGCT1:IT", this.d);
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x0013A490 File Offset: 0x00138690
	public string d()
	{
		return this.a;
	}

	// Token: 0x06003291 RID: 12945 RVA: 0x0013A498 File Offset: 0x00138698
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x0013A4A4 File Offset: 0x001386A4
	public string a()
	{
		return this.b;
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x0013A4AC File Offset: 0x001386AC
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x0013A4B8 File Offset: 0x001386B8
	public Guid? b()
	{
		return this.c;
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x0013A4C0 File Offset: 0x001386C0
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06003296 RID: 12950 RVA: 0x0013A4CC File Offset: 0x001386CC
	public bool c()
	{
		return this.d;
	}

	// Token: 0x06003297 RID: 12951 RVA: 0x0013A4D4 File Offset: 0x001386D4
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06003298 RID: 12952 RVA: 0x0013A4E0 File Offset: 0x001386E0
	public ecx()
	{
	}

	// Token: 0x06003299 RID: 12953 RVA: 0x0013A4F4 File Offset: 0x001386F4
	protected override void adf(c5x A_0)
	{
		if (this.c != null && A_0.Area != null)
		{
			c5x c5x = A_0.Area.a(this.c.Value) as c5x;
			int num = new Random().Next(0, 2);
			if (c5x != null && c5x.u.b != null && num == 0)
			{
				c5x.u.b.a(this.a, this.d, null, null);
			}
			if (c5x != null && c5x.u.b != null && num == 1)
			{
				c5x.u.b.a(this.b, this.d, null, null);
				return;
			}
			c5x.u.b.a(this.a, this.d, null, null);
		}
	}

	// Token: 0x04001B05 RID: 6917
	private string a;

	// Token: 0x04001B06 RID: 6918
	private string b;

	// Token: 0x04001B07 RID: 6919
	private Guid? c;

	// Token: 0x04001B08 RID: 6920
	private new bool d = true;
}
