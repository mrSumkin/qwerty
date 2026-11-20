using System;
using System.Runtime.Serialization;

// Token: 0x02001468 RID: 5224
[eiz("CA5")]
[Serializable]
public sealed class d5g : awx, afq, v2, ISerializable
{
	// Token: 0x060075C7 RID: 30151 RVA: 0x0031D79C File Offset: 0x0031B99C
	private d5g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (afq)A_0.GetValue("CA5:BA", typeof(afq));
			this.b = (ad5)A_0.GetValue("CA5:R", typeof(ad5));
			return;
		}
		if (base.GetType() == typeof(d5g))
		{
			this.a = (afq)A_0.GetValue("_BreakAction", typeof(afq));
			this.b = (ad5)A_0.GetValue("_Root", typeof(ad5));
			return;
		}
		this.a = (afq)A_0.GetValue("ChannellingAction+_BreakAction", typeof(afq));
		this.b = (ad5)A_0.GetValue("ChannellingAction+_Root", typeof(ad5));
	}

	// Token: 0x060075C8 RID: 30152 RVA: 0x0031D898 File Offset: 0x0031BA98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CA5:BA", this.a);
		info.AddValue("CA5:R", this.b);
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x060075C9 RID: 30153 RVA: 0x0031D8C4 File Offset: 0x0031BAC4
	// (set) Token: 0x060075CA RID: 30154 RVA: 0x0031D8CC File Offset: 0x0031BACC
	public ad5 Root
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

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x060075CB RID: 30155 RVA: 0x0031D8D8 File Offset: 0x0031BAD8
	public double PushbackFactor
	{
		get
		{
			return as3.bf;
		}
	}

	// Token: 0x060075CC RID: 30156 RVA: 0x0031D8E0 File Offset: 0x0031BAE0
	public d5g(ad5 A_0, afq A_1, afq A_2, afq A_3, afq A_4, params evd[] A_5)
	{
		czh.a(A_0, "root");
		this.b = A_0;
		this.a = A_4;
		base.b(true);
		base.c(true);
		if (A_1 != null)
		{
			base.ad().Add(A_1);
		}
		if (A_2 != null)
		{
			boa boa = A_0.d8(A_2, A_5);
			if (boa != null)
			{
				boa.l(new EventHandler<EventArgs>(this.a));
				boa.o(new EventHandler<EventArgs>(this.a));
				base.ad().Add(boa);
			}
		}
		if (A_3 != null)
		{
			base.ad().Add(A_3);
		}
	}

	// Token: 0x060075CD RID: 30157 RVA: 0x0031D988 File Offset: 0x0031BB88
	public void j3(int A_0)
	{
		boa boa = base.aa() as boa;
		if (boa != null && boa.x() == dc4.b)
		{
			boa.a(A_0);
		}
	}

	// Token: 0x060075CE RID: 30158 RVA: 0x0031D9BC File Offset: 0x0031BBBC
	[dcc("CA5:mOTAB")]
	private new void a(object A_0, EventArgs A_1)
	{
		if (this.a != null)
		{
			base.y().g9(this.a, atp.a);
		}
	}

	// Token: 0x0400302B RID: 12331
	private new afq a;

	// Token: 0x0400302C RID: 12332
	private ad5 b;
}
