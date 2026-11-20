using System;
using System.Runtime.Serialization;

// Token: 0x02001A3C RID: 6716
[eiz("HER")]
[Serializable]
public sealed class edm : ISerializable
{
	// Token: 0x06009196 RID: 37270 RVA: 0x0039D470 File Offset: 0x0039B670
	private edm(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("HER:V");
			this.b = A_0.GetString("HER:N");
			if (ell.a() >= 99)
			{
				this.c = A_0.GetDouble("HER:C");
			}
			else
			{
				this.c = (double)A_0.GetSingle("HER:C");
			}
			this.d = A_0.GetInt32("HER:P");
			return;
		}
		if (base.GetType() == typeof(edm))
		{
			this.a = A_0.GetBoolean("_Visible");
			this.b = A_0.GetString("_Name");
			this.c = (double)A_0.GetSingle("_Chance");
			this.d = A_0.GetInt32("_Power");
			return;
		}
		this.a = A_0.GetBoolean("HitEffectReference+_Visible");
		this.b = A_0.GetString("HitEffectReference+_Name");
		this.c = (double)A_0.GetSingle("HitEffectReference+_Chance");
		this.d = A_0.GetInt32("HitEffectReference+_Power");
	}

	// Token: 0x06009197 RID: 37271 RVA: 0x0039D5A4 File Offset: 0x0039B7A4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("HER:V", this.a);
		info.AddValue("HER:N", this.b);
		info.AddValue("HER:C", this.c);
		info.AddValue("HER:P", this.d);
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06009198 RID: 37272 RVA: 0x0039D5F8 File Offset: 0x0039B7F8
	// (set) Token: 0x06009199 RID: 37273 RVA: 0x0039D600 File Offset: 0x0039B800
	public string Name
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600919A RID: 37274 RVA: 0x0039D60C File Offset: 0x0039B80C
	// (set) Token: 0x0600919B RID: 37275 RVA: 0x0039D614 File Offset: 0x0039B814
	public double Chance
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600919C RID: 37276 RVA: 0x0039D620 File Offset: 0x0039B820
	// (set) Token: 0x0600919D RID: 37277 RVA: 0x0039D628 File Offset: 0x0039B828
	public int Power
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x0600919E RID: 37278 RVA: 0x0039D634 File Offset: 0x0039B834
	// (set) Token: 0x0600919F RID: 37279 RVA: 0x0039D63C File Offset: 0x0039B83C
	public bool Visible
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060091A0 RID: 37280 RVA: 0x0039D648 File Offset: 0x0039B848
	public edm()
	{
	}

	// Token: 0x060091A1 RID: 37281 RVA: 0x0039D658 File Offset: 0x0039B858
	public edm(string A_0, double A_1, int A_2, bool A_3 = true)
	{
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.a = A_3;
	}

	// Token: 0x060091A2 RID: 37282 RVA: 0x0039D684 File Offset: 0x0039B884
	public buu d()
	{
		return az9.a(this.b);
	}

	// Token: 0x060091A3 RID: 37283 RVA: 0x0039D694 File Offset: 0x0039B894
	public string b()
	{
		buu buu = this.d();
		if (buu != null)
		{
			return buu.e1(this);
		}
		return null;
	}

	// Token: 0x060091A4 RID: 37284 RVA: 0x0039D6B8 File Offset: 0x0039B8B8
	public bool a()
	{
		buu buu = this.d();
		return buu != null && buu.yk(this);
	}

	// Token: 0x060091A5 RID: 37285 RVA: 0x0039D6DC File Offset: 0x0039B8DC
	public edm g()
	{
		return new edm
		{
			b = this.b,
			c = this.c,
			d = this.d
		};
	}

	// Token: 0x04003831 RID: 14385
	private bool a = true;

	// Token: 0x04003832 RID: 14386
	private string b;

	// Token: 0x04003833 RID: 14387
	private double c;

	// Token: 0x04003834 RID: 14388
	private int d;
}
