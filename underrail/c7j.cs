using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02001271 RID: 4721
[cnn("TimelapseVertigo.Playfield.Design.Forms.ContainerAspectEditorForm, TimelapseVertigo.Playfield.Design")]
[eiz("CEA3")]
[a(typeof(bim))]
[Serializable]
public class c7j : b0e, dex, csy, ISerializable, c98
{
	// Token: 0x0600666F RID: 26223 RVA: 0x002B90DC File Offset: 0x002B72DC
	protected c7j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (dbi)A_0.GetValue("CEA3:IC", typeof(dbi));
			this.b = (ctz)A_0.GetValue("CEA3:CPM", typeof(ctz));
			if (ell.a() >= 241)
			{
				this.c = A_0.GetBoolean("CEA3:I");
				return;
			}
		}
		else
		{
			this.a = (A_0.GetValue("_ItemContainer", typeof(dbi)) as dbi);
			try
			{
				this.b = (ctz)A_0.GetValue("CEA_CPM", typeof(ctz));
			}
			catch
			{
			}
		}
	}

	// Token: 0x06006670 RID: 26224 RVA: 0x002B91C4 File Offset: 0x002B73C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEA3:IC", this.a);
		info.AddValue("CEA3:CPM", this.b);
		info.AddValue("CEA3:I", this.c);
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06006671 RID: 26225 RVA: 0x002B9214 File Offset: 0x002B7414
	// (set) Token: 0x06006672 RID: 26226 RVA: 0x002B921C File Offset: 0x002B741C
	[Browsable(false)]
	public dbi ItemContainer
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

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06006673 RID: 26227 RVA: 0x002B9228 File Offset: 0x002B7428
	// (set) Token: 0x06006674 RID: 26228 RVA: 0x002B9230 File Offset: 0x002B7430
	public ctz ContainerProtectionMode
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

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06006675 RID: 26229 RVA: 0x002B923C File Offset: 0x002B743C
	// (set) Token: 0x06006676 RID: 26230 RVA: 0x002B9240 File Offset: 0x002B7440
	public override d98 InteractionType
	{
		get
		{
			return d98.d;
		}
		set
		{
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06006677 RID: 26231 RVA: 0x002B9244 File Offset: 0x002B7444
	// (set) Token: 0x06006678 RID: 26232 RVA: 0x002B9248 File Offset: 0x002B7448
	public override bool CanUseInCombat
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06006679 RID: 26233 RVA: 0x002B924C File Offset: 0x002B744C
	public bool Inspected
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x0600667A RID: 26234 RVA: 0x002B9254 File Offset: 0x002B7454
	public c7j(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600667B RID: 26235 RVA: 0x002B926C File Offset: 0x002B746C
	public void kk(dbi A_0, coh A_1, object A_2)
	{
		amc amc = A_2 as amc;
		if (amc != null && base.a8() != null && (this.b == ctz.b || this.b == ctz.d))
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null && aspect.a(amc))
			{
				aspect.e();
			}
		}
	}

	// Token: 0x0600667C RID: 26236 RVA: 0x002B92D0 File Offset: 0x002B74D0
	public void kl(dbi A_0, coh A_1, object A_2)
	{
		amc amc = A_2 as amc;
		if (amc != null && base.a8() != null && this.b != ctz.a)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null && aspect.a(amc) && aspect.e() && aspect.e())
			{
				a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
			}
		}
	}

	// Token: 0x0600667D RID: 26237 RVA: 0x002B9344 File Offset: 0x002B7544
	public bool ki(dbi A_0, coh A_1, object A_2)
	{
		return true;
	}

	// Token: 0x0600667E RID: 26238 RVA: 0x002B9348 File Offset: 0x002B7548
	public bool kj(dbi A_0, coh A_1, object A_2)
	{
		return true;
	}

	// Token: 0x0600667F RID: 26239 RVA: 0x002B9350 File Offset: 0x002B7550
	public void r7(eds A_0)
	{
		if (this.c && this.a != null && !string.IsNullOrEmpty(base.a8().y8()))
		{
			if (this.a.z2().Count > 0)
			{
				if (base.a8().y8().EndsWith(")"))
				{
					base.a8().q(base.a8().y8().Substring(0, base.a8().y8().Length - 8));
					return;
				}
			}
			else if (!base.a8().y8().EndsWith(")"))
			{
				c5x c5x = base.a8();
				c5x.q(c5x.y8() + " (пусто)");
			}
		}
	}

	// Token: 0x06006680 RID: 26240 RVA: 0x002B941C File Offset: 0x002B761C
	protected override void m0(c5x A_0, c3g A_1, string A_2)
	{
		if (this.b == ctz.b && A_0.h.b != null)
		{
			A_1.a(A_0.h.b);
			return;
		}
		if (base.a8() != null)
		{
			d2b aspect = base.a8().GetAspect<d2b>();
			if (aspect != null)
			{
				aspect.b(A_0.h.b);
			}
		}
	}

	// Token: 0x06006681 RID: 26241 RVA: 0x002B9488 File Offset: 0x002B7688
	protected override void mz(c5x A_0, string A_1 = null)
	{
		base.d(true);
		if (A_0 == null)
		{
			dux.b(LogSeverity.Error, "Инициатор с нулевым значением попытался открыть контейнер ({0}).", new object[]
			{
				base.a8().ToString()
			});
		}
		ny aspect = A_0.GetAspect<ny>();
		if (aspect == null)
		{
			dux.b(LogSeverity.Error, "Инициатор без аспекта сущности действия попытался открыть контейнер ({0}).", new object[]
			{
				base.a8().ToString()
			});
		}
		this.af4(A_0);
		bx5 bx = new bx5(A_0);
		bx.l(new EventHandler<EventArgs>(this.a));
		aspect.a(bx, atp.a, true, false);
		a7v.a(new bsh(A_0, this));
		this.c = true;
	}

	// Token: 0x06006682 RID: 26242 RVA: 0x002B952C File Offset: 0x002B772C
	[dcc("CEA3:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		bx5 bx = A_0 as bx5;
		if (bx != null && base.a8().Zone != null)
		{
			this.af5(bx.a());
		}
		base.d(false);
		a7v.a(new md(bx.a(), this));
	}

	// Token: 0x04002A86 RID: 10886
	private new dbi a = new dcw();

	// Token: 0x04002A87 RID: 10887
	private new ctz b;

	// Token: 0x04002A88 RID: 10888
	internal bool c;
}
