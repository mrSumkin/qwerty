using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x020012E3 RID: 4835
[a(typeof(bim))]
[eiz("C25")]
[Serializable]
public class akr : b0e, ISerializable, d9i
{
	// Token: 0x06006B35 RID: 27445 RVA: 0x002D1618 File Offset: 0x002CF818
	protected akr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("C25:A");
		this.b = (Guid)A_0.GetValue("C25:E", typeof(Guid));
		this.c = A_0.GetInt32("C25:S");
		if (ell.a() >= 82)
		{
			this.d = A_0.GetString("C25:N");
			this.e = (A_0.GetValue("C25:C", typeof(Point?)) as Point?);
		}
	}

	// Token: 0x06006B36 RID: 27446 RVA: 0x002D16B4 File Offset: 0x002CF8B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C25:A", this.a);
		info.AddValue("C25:E", this.b);
		info.AddValue("C25:S", this.c);
		info.AddValue("C25:N", this.d);
		info.AddValue("C25:C", this.e);
	}

	// Token: 0x06006B37 RID: 27447 RVA: 0x002D1728 File Offset: 0x002CF928
	public string b()
	{
		return this.a;
	}

	// Token: 0x06006B38 RID: 27448 RVA: 0x002D1730 File Offset: 0x002CF930
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B39 RID: 27449 RVA: 0x002D173C File Offset: 0x002CF93C
	public Guid e()
	{
		return this.b;
	}

	// Token: 0x06006B3A RID: 27450 RVA: 0x002D1744 File Offset: 0x002CF944
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006B3B RID: 27451 RVA: 0x002D1750 File Offset: 0x002CF950
	public int a()
	{
		return this.c;
	}

	// Token: 0x06006B3C RID: 27452 RVA: 0x002D1758 File Offset: 0x002CF958
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B3D RID: 27453 RVA: 0x002D1764 File Offset: 0x002CF964
	public string f()
	{
		return this.d;
	}

	// Token: 0x06006B3E RID: 27454 RVA: 0x002D176C File Offset: 0x002CF96C
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B3F RID: 27455 RVA: 0x002D1778 File Offset: 0x002CF978
	public Point? d()
	{
		return this.e;
	}

	// Token: 0x06006B40 RID: 27456 RVA: 0x002D1780 File Offset: 0x002CF980
	public void a(Point? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B41 RID: 27457 RVA: 0x002D178C File Offset: 0x002CF98C
	public override d98 pr()
	{
		return d98.b;
	}

	// Token: 0x06006B42 RID: 27458 RVA: 0x002D1790 File Offset: 0x002CF990
	public override void ps(d98 A_0)
	{
	}

	// Token: 0x06006B43 RID: 27459 RVA: 0x002D1794 File Offset: 0x002CF994
	public akr(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B44 RID: 27460 RVA: 0x002D17A0 File Offset: 0x002CF9A0
	public void pt(bool A_0)
	{
		if (!A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anb(this);
			}
		}
	}

	// Token: 0x06006B45 RID: 27461 RVA: 0x002D17C8 File Offset: 0x002CF9C8
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (base.a8().a())
		{
			base.d(true);
			if (A_0 == null)
			{
				dux.b(LogSeverity.Error, "Null initiator attempted to a interact with a monitor ({0}).", new object[]
				{
					base.a8().ToString()
				});
			}
			ny aspect = A_0.GetAspect<ny>();
			if (aspect == null)
			{
				dux.b(LogSeverity.Error, "Initiator without action entity aspect attempted to interact with a monitor ({0}).", new object[]
				{
					base.a8().ToString()
				});
			}
			this.af4(A_0);
			bx5 bx = new bx5(A_0);
			bx.l(new EventHandler<EventArgs>(this.a));
			aspect.a(bx, atp.a, true, false);
			a7v.a(new nq(A_0, this));
			return;
		}
		if (A_0 != null && A_0.IsPlayer)
		{
			bmj.a(base.a8(), new d53("Тут пусто.", adi.l, null, false));
		}
	}

	// Token: 0x06006B46 RID: 27462 RVA: 0x002D18A4 File Offset: 0x002CFAA4
	[dcc("C25:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		bx5 bx = A_0 as bx5;
		if (bx != null)
		{
			this.af5(bx.a());
		}
		base.d(false);
		a7v.a(new ehk(bx.a(), this));
	}

	// Token: 0x04002C07 RID: 11271
	private new string a;

	// Token: 0x04002C08 RID: 11272
	private new Guid b;

	// Token: 0x04002C09 RID: 11273
	private int c;

	// Token: 0x04002C0A RID: 11274
	private string d;

	// Token: 0x04002C0B RID: 11275
	private Point? e;
}
