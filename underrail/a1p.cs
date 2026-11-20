using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000F6A RID: 3946
[a(typeof(epo))]
[eiz("GPEA")]
[Serializable]
public sealed class a1p : epo
{
	// Token: 0x06004FFF RID: 20479 RVA: 0x0023E688 File Offset: 0x0023C888
	private a1p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("GPEA:T", typeof(List<string>)) as List<string>);
		this.c = A_0.GetString("GPEA:W");
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x0023E6C4 File Offset: 0x0023C8C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GPEA:T", this.b);
		info.AddValue("GPEA:W", this.c);
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x0023E6F0 File Offset: 0x0023C8F0
	public a1p(c5x A_0) : base(A_0)
	{
		this.b = new List<string>
		{
			"gunslingerPortal"
		};
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x0023E710 File Offset: 0x0023C910
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x0023E718 File Offset: 0x0023C918
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x0023E724 File Offset: 0x0023C924
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x0023E72C File Offset: 0x0023C92C
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x0023E738 File Offset: 0x0023C938
	public override bool kc(c5x A_0, abo A_1)
	{
		aw1.b(A_0, base.a8(), false);
		return true;
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x0023E74C File Offset: 0x0023C94C
	protected override List<d0z> kd()
	{
		if (this.a == null)
		{
			List<object> a_ = new List<object>(this.b);
			this.a = new List<d0z>
			{
				new d0z(base.a8().qe().ToString(), this.a(true), this.a(false), a_)
			};
		}
		return this.a;
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x0023E7B4 File Offset: 0x0023C9B4
	private abo a(bool A_0)
	{
		abo result = default(abo);
		if (A_0)
		{
			result = new abo(new ee4(base.a8().Area.c(), new Point((int)base.a8().Location.X * 4, (int)base.a8().Location.Y * 4)), chj.a, aj.a, 0, null);
		}
		else
		{
			csd csd = base.a8().Zone.g(this.c);
			if (csd != null)
			{
				result = new abo(new ee4(base.a8().Zone.n(csd.AreaName).c(), new Point((int)csd.Location.X * 4, (int)csd.Location.Y * 4)), chj.a, aj.a, 0, null);
			}
		}
		return result;
	}

	// Token: 0x040020A4 RID: 8356
	[NonSerialized]
	private List<d0z> a;

	// Token: 0x040020A5 RID: 8357
	private new List<string> b;

	// Token: 0x040020A6 RID: 8358
	private new string c;
}
