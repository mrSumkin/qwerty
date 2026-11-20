using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200125F RID: 4703
[eiz("BACEA")]
[a(typeof(bim))]
[Serializable]
public sealed class bb2 : bim, ISerializable, c98
{
	// Token: 0x060065BD RID: 26045 RVA: 0x002B5114 File Offset: 0x002B3314
	private bb2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (BaseAbilityEnum)A_0.GetValue("BACEA:B", typeof(BaseAbilityEnum));
		this.b = A_0.GetString("BACEA:A");
		this.c = A_0.GetInt32("BACEA:V");
		if (ell.a() >= 453)
		{
			this.d = A_0.GetBoolean("BACEA:E");
		}
		else
		{
			this.d = true;
		}
		if (ell.a() >= 491)
		{
			this.e = (A_0.GetValue("BACEA:F", typeof(IFunction<c5x, c5x, int>)) as IFunction<c5x, c5x, int>);
		}
		if (ell.a() >= 625)
		{
			this.f = A_0.GetSingle("BACEA:FD");
		}
	}

	// Token: 0x060065BE RID: 26046 RVA: 0x002B51F8 File Offset: 0x002B33F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BACEA:B", this.a);
		info.AddValue("BACEA:A", this.b);
		info.AddValue("BACEA:V", this.c);
		info.AddValue("BACEA:E", this.d);
		info.AddValue("BACEA:F", this.e);
		info.AddValue("BACEA:FD", this.f);
	}

	// Token: 0x060065BF RID: 26047 RVA: 0x002B5278 File Offset: 0x002B3478
	public BaseAbilityEnum b()
	{
		return this.a;
	}

	// Token: 0x060065C0 RID: 26048 RVA: 0x002B5280 File Offset: 0x002B3480
	public void a(BaseAbilityEnum A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060065C1 RID: 26049 RVA: 0x002B528C File Offset: 0x002B348C
	public string e()
	{
		return this.b;
	}

	// Token: 0x060065C2 RID: 26050 RVA: 0x002B5294 File Offset: 0x002B3494
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060065C3 RID: 26051 RVA: 0x002B52A0 File Offset: 0x002B34A0
	public int g()
	{
		return this.c;
	}

	// Token: 0x060065C4 RID: 26052 RVA: 0x002B52A8 File Offset: 0x002B34A8
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060065C5 RID: 26053 RVA: 0x002B52B4 File Offset: 0x002B34B4
	public bool f()
	{
		return this.d;
	}

	// Token: 0x060065C6 RID: 26054 RVA: 0x002B52BC File Offset: 0x002B34BC
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060065C7 RID: 26055 RVA: 0x002B52C8 File Offset: 0x002B34C8
	public IFunction<c5x, c5x, int> h()
	{
		return this.e;
	}

	// Token: 0x060065C8 RID: 26056 RVA: 0x002B52D0 File Offset: 0x002B34D0
	public void a(IFunction<c5x, c5x, int> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060065C9 RID: 26057 RVA: 0x002B52DC File Offset: 0x002B34DC
	public float d()
	{
		return this.f;
	}

	// Token: 0x060065CA RID: 26058 RVA: 0x002B52E4 File Offset: 0x002B34E4
	public void b(float A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060065CB RID: 26059 RVA: 0x002B52F0 File Offset: 0x002B34F0
	public bb2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060065CC RID: 26060 RVA: 0x002B530C File Offset: 0x002B350C
	public override void mx()
	{
		base.mx();
		if (bpo.GetService<cnk>() != null)
		{
			this.a(0f);
			return;
		}
		this.a(1f);
	}

	// Token: 0x060065CD RID: 26061 RVA: 0x002B5338 File Offset: 0x002B3538
	public override void my()
	{
		base.my();
		if (bpo.GetService<cnk>() != null)
		{
			this.a(0f);
			return;
		}
		this.a(1f);
	}

	// Token: 0x060065CE RID: 26062 RVA: 0x002B5364 File Offset: 0x002B3564
	public void r7(eds A_0)
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			this.a();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (this.d && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area)
			{
				double num = aw1.b(base.a8(), serviceOrThrow.aqu().v().b());
				float a_ = d05.b(0f, (float)((double)this.f - num) / (this.f - 2f), 0.8f);
				this.a(a_, A_0.b.TotalMilliseconds);
				return;
			}
			this.a(0f);
		}
	}

	// Token: 0x060065CF RID: 26063 RVA: 0x002B5460 File Offset: 0x002B3660
	protected override bool ww(c5x A_0, out string A_1)
	{
		if (!base.ww(A_0, out A_1) || A_0 == null || A_0.h.b == null)
		{
			return false;
		}
		int num = c2h.a(A_0.h.b.aa(), this.a);
		int num2;
		if (this.e != null)
		{
			num2 = this.e.wv(A_0, base.a8());
		}
		else
		{
			num2 = this.c;
		}
		if (num >= num2)
		{
			return true;
		}
		A_1 = "Не удалось выполнить действие";
		return false;
	}

	// Token: 0x060065D0 RID: 26064 RVA: 0x002B54E8 File Offset: 0x002B36E8
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num;
		if (this.e != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() is c5x)
		{
			num = this.e.wv(serviceOrThrow.aqu().v().b() as c5x, base.a8());
		}
		else
		{
			num = this.c;
		}
		string text = "";
		if (base.a8() != null && base.a8().o.b != null)
		{
			int x = 0;
			if (this.a == BaseAbilityEnum.Strength)
			{
				x = 1;
			}
			else if (this.a == BaseAbilityEnum.Agility)
			{
				x = 0;
			}
			else if (this.a == BaseAbilityEnum.Dexterity)
			{
				x = 2;
			}
			else if (this.a == BaseAbilityEnum.Perception)
			{
				x = 3;
			}
			base.a8().o.b.b = new Point(x, 0);
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				if (c2h.a(serviceOrThrow.aqu().v(), this.a) >= num)
				{
					base.a8().o.b.c = new Color?(Color.Blue);
				}
				else
				{
					base.a8().o.b.c = new Color?(Color.OrangeRed);
				}
			}
		}
		if (this.a == BaseAbilityEnum.Agility && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			if (serviceOrThrow.aqu().v().SpecialStates.b)
			{
				text = " [обездвиженность]";
			}
			else if (serviceOrThrow.aqu().v().EncumbranceLevel == db9.d)
			{
				text = " [перегруженность]";
			}
			else if (serviceOrThrow.aqu().v().EncumbranceLevel == db9.c)
			{
				text = " [сильно перегружены]";
			}
			else if (serviceOrThrow.aqu().v().EncumbranceLevel == db9.b)
			{
				text = " [легко перегружены]";
			}
		}
		base.a8().q(string.Format("{0} ({1} {2}){3}", new object[]
		{
			this.b,
			this.a.ToString(),
			num,
			text
		}));
	}

	// Token: 0x060065D1 RID: 26065 RVA: 0x002B5764 File Offset: 0x002B3964
	private void a(float A_0)
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			base.a8().o.b.d = new float?(A_0);
		}
		base.g(A_0 > 0f);
	}

	// Token: 0x060065D2 RID: 26066 RVA: 0x002B57BC File Offset: 0x002B39BC
	private void a(float A_0, double A_1)
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			float valueOrDefault = base.a8().o.b.d.GetValueOrDefault(1f);
			float num = (float)(A_1 * 0.001);
			if (valueOrDefault < A_0)
			{
				this.a(Math.Min(A_0, base.a8().o.b.d.GetValueOrDefault(1f) + num));
				return;
			}
			if (valueOrDefault > A_0)
			{
				this.a(Math.Max(A_0, base.a8().o.b.d.GetValueOrDefault(1f) - num));
			}
		}
	}

	// Token: 0x04002A53 RID: 10835
	private new BaseAbilityEnum a;

	// Token: 0x04002A54 RID: 10836
	private string b;

	// Token: 0x04002A55 RID: 10837
	private int c;

	// Token: 0x04002A56 RID: 10838
	private bool d = true;

	// Token: 0x04002A57 RID: 10839
	private IFunction<c5x, c5x, int> e;

	// Token: 0x04002A58 RID: 10840
	private float f = 5f;
}
