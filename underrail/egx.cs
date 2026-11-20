using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001127 RID: 4391
[eiz("TJ1")]
[Serializable]
public sealed class egx : cze, ISerializable
{
	// Token: 0x06005DDD RID: 24029 RVA: 0x0027D088 File Offset: 0x0027B288
	private egx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Color?)A_0.GetValue("TJ1:OTC", typeof(Color?));
			this.b = A_0.GetString("TJ1:T");
			this.c = A_0.GetBoolean("TJ1:I");
			this.d = A_0.GetBoolean("TJ1:IT");
			return;
		}
		if (base.GetType() == typeof(egx))
		{
			this.a = (Color?)A_0.GetValue("_OverrideTextColor", typeof(Color?));
			this.b = A_0.GetString("_Text");
			this.c = A_0.GetBoolean("_Interrupt");
			this.d = A_0.GetBoolean("_InitiatorTalks");
			return;
		}
		this.a = (Color?)A_0.GetValue("TalkJob+_OverrideTextColor", typeof(Color?));
		this.b = A_0.GetString("TalkJob+_Text");
		this.c = A_0.GetBoolean("TalkJob+_Interrupt");
		this.d = A_0.GetBoolean("TalkJob+_InitiatorTalks");
	}

	// Token: 0x06005DDE RID: 24030 RVA: 0x0027D1BC File Offset: 0x0027B3BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TJ1:OTC", this.a);
		info.AddValue("TJ1:T", this.b);
		info.AddValue("TJ1:I", this.c);
		info.AddValue("TJ1:IT", this.d);
	}

	// Token: 0x06005DDF RID: 24031 RVA: 0x0027D21C File Offset: 0x0027B41C
	public Color? b()
	{
		return this.a;
	}

	// Token: 0x06005DE0 RID: 24032 RVA: 0x0027D224 File Offset: 0x0027B424
	public void a(Color? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DE1 RID: 24033 RVA: 0x0027D230 File Offset: 0x0027B430
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005DE2 RID: 24034 RVA: 0x0027D238 File Offset: 0x0027B438
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DE3 RID: 24035 RVA: 0x0027D244 File Offset: 0x0027B444
	public bool c()
	{
		return this.c;
	}

	// Token: 0x06005DE4 RID: 24036 RVA: 0x0027D24C File Offset: 0x0027B44C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005DE5 RID: 24037 RVA: 0x0027D258 File Offset: 0x0027B458
	public bool d()
	{
		return this.d;
	}

	// Token: 0x06005DE6 RID: 24038 RVA: 0x0027D260 File Offset: 0x0027B460
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005DE7 RID: 24039 RVA: 0x0027D26C File Offset: 0x0027B46C
	public egx()
	{
	}

	// Token: 0x06005DE8 RID: 24040 RVA: 0x0027D278 File Offset: 0x0027B478
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b;
		if (this.d)
		{
			b0b = A_0;
		}
		else
		{
			b0b = A_1;
		}
		if (b0b != null)
		{
			c0s aspect = b0b.GetAspect<c0s>();
			if (aspect != null)
			{
				aspect.a(this.b, this.c, this.a, null);
			}
		}
	}

	// Token: 0x0400255A RID: 9562
	private new Color? a;

	// Token: 0x0400255B RID: 9563
	private string b;

	// Token: 0x0400255C RID: 9564
	private bool c;

	// Token: 0x0400255D RID: 9565
	private bool d;
}
