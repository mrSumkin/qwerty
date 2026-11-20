using System;
using System.Runtime.Serialization;

// Token: 0x02000665 RID: 1637
[eiz("TDY")]
[Serializable]
public sealed class d9n : ISerializable
{
	// Token: 0x06002993 RID: 10643 RVA: 0x000EC9BC File Offset: 0x000EABBC
	private d9n(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (a0)A_0.GetValue("TDY:C", typeof(a0));
		this.b = A_0.GetBoolean("TDY:A");
		this.c = A_0.GetBoolean("TDY:U");
		this.d = A_0.GetInt32("TDY:R");
		this.e = A_0.GetInt32("TDY:N");
		this.f = A_0.GetInt32("TDY:X");
		if (ell.a() >= 648)
		{
			this.g = (A_0.GetValue("TDY:O", typeof(dth)) as dth);
		}
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x000ECA88 File Offset: 0x000EAC88
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TDY:C", this.a);
		info.AddValue("TDY:A", this.b);
		info.AddValue("TDY:U", this.c);
		info.AddValue("TDY:R", this.d);
		info.AddValue("TDY:N", this.e);
		info.AddValue("TDY:X", this.f);
		info.AddValue("TDY:O", this.g);
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06002995 RID: 10645 RVA: 0x000ECB14 File Offset: 0x000EAD14
	// (set) Token: 0x06002996 RID: 10646 RVA: 0x000ECB1C File Offset: 0x000EAD1C
	public a0 Category
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

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06002997 RID: 10647 RVA: 0x000ECB28 File Offset: 0x000EAD28
	// (set) Token: 0x06002998 RID: 10648 RVA: 0x000ECB30 File Offset: 0x000EAD30
	public bool AlwaysInclude
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

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06002999 RID: 10649 RVA: 0x000ECB3C File Offset: 0x000EAD3C
	// (set) Token: 0x0600299A RID: 10650 RVA: 0x000ECB44 File Offset: 0x000EAD44
	public bool UnlimitedDemand
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

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x0600299B RID: 10651 RVA: 0x000ECB50 File Offset: 0x000EAD50
	// (set) Token: 0x0600299C RID: 10652 RVA: 0x000ECB58 File Offset: 0x000EAD58
	public int RarityFactor
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

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600299D RID: 10653 RVA: 0x000ECB64 File Offset: 0x000EAD64
	// (set) Token: 0x0600299E RID: 10654 RVA: 0x000ECB6C File Offset: 0x000EAD6C
	public int MinDemand
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x0600299F RID: 10655 RVA: 0x000ECB78 File Offset: 0x000EAD78
	// (set) Token: 0x060029A0 RID: 10656 RVA: 0x000ECB80 File Offset: 0x000EAD80
	public int MaxDemand
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000ECB8C File Offset: 0x000EAD8C
	// (set) Token: 0x060029A2 RID: 10658 RVA: 0x000ECB94 File Offset: 0x000EAD94
	public dth Condition
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x000ECBA0 File Offset: 0x000EADA0
	public d9n()
	{
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x000ECBC0 File Offset: 0x000EADC0
	public override string ToString()
	{
		string text;
		if (this.c)
		{
			text = string.Format("{0}: неограниченно.", this.a);
		}
		else if (this.b)
		{
			text = string.Format("{0} {1}-{2}", this.a, this.e, this.f);
		}
		else
		{
			text = string.Format("{0} {1}-{2} (r:{3})", new object[]
			{
				this.a,
				this.e,
				this.f,
				this.d
			});
		}
		if (this.g != null)
		{
			text = text + " [" + this.g.ToString() + "]";
		}
		return text;
	}

	// Token: 0x040016A8 RID: 5800
	private a0 a;

	// Token: 0x040016A9 RID: 5801
	private bool b;

	// Token: 0x040016AA RID: 5802
	private bool c;

	// Token: 0x040016AB RID: 5803
	private int d = 1;

	// Token: 0x040016AC RID: 5804
	private int e = 1;

	// Token: 0x040016AD RID: 5805
	private int f = 1;

	// Token: 0x040016AE RID: 5806
	private dth g;
}
