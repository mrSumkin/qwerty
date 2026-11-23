using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;

// Token: 0x020012A9 RID: 4777
[eiz("RGCEA")]
[Serializable]
public sealed class bvy : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x06006890 RID: 26768 RVA: 0x002C34E0 File Offset: 0x002C16E0
	private bvy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("RGCEA:P");
		this.c = A_0.GetInt32("RGCEA:S");
		this.d = A_0.GetInt32("RGCEA:U");
		this.e = A_0.GetInt32("RGCEA:R");
		this.f = A_0.GetString("RGCEA:C");
		this.g = (A_0.GetValue("RGCEA:OM", typeof(bjp)) as bjp);
		this.h = (A_0.GetValue("RGCEA:UM", typeof(bjp)) as bjp);
		this.i = A_0.GetDouble("RGCEA:T");
		this.j = A_0.GetInt32("RGCEA:TP");
		this.k = A_0.GetInt32("RGCEA:TS");
		if (ell.a() >= 478)
		{
			this.l = (A_0.GetValue("RGCEA:A", typeof(Axis?)) as Axis?);
		}
	}

	// Token: 0x06006891 RID: 26769 RVA: 0x002C3610 File Offset: 0x002C1810
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RGCEA:P", this.b);
		info.AddValue("RGCEA:S", this.c);
		info.AddValue("RGCEA:U", this.d);
		info.AddValue("RGCEA:R", this.e);
		info.AddValue("RGCEA:C", this.f);
		info.AddValue("RGCEA:OM", this.g);
		info.AddValue("RGCEA:UM", this.h);
		info.AddValue("RGCEA:T", this.i);
		info.AddValue("RGCEA:TP", this.j);
		info.AddValue("RGCEA:TS", this.k);
		info.AddValue("RGCEA:A", this.l);
	}

	// Token: 0x06006892 RID: 26770 RVA: 0x002C36E8 File Offset: 0x002C18E8
	public int d()
	{
		return this.b;
	}

	// Token: 0x06006893 RID: 26771 RVA: 0x002C36F0 File Offset: 0x002C18F0
	public void b(int A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.g();
		}
	}

	// Token: 0x06006894 RID: 26772 RVA: 0x002C370C File Offset: 0x002C190C
	public int f()
	{
		return this.c;
	}

	// Token: 0x06006895 RID: 26773 RVA: 0x002C3714 File Offset: 0x002C1914
	public void f(int A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			this.g();
		}
	}

	// Token: 0x06006896 RID: 26774 RVA: 0x002C3730 File Offset: 0x002C1930
	public int k()
	{
		return this.d;
	}

	// Token: 0x06006897 RID: 26775 RVA: 0x002C3738 File Offset: 0x002C1938
	public void a(int A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.g();
		}
	}

	// Token: 0x06006898 RID: 26776 RVA: 0x002C3754 File Offset: 0x002C1954
	public int l()
	{
		return this.e;
	}

	// Token: 0x06006899 RID: 26777 RVA: 0x002C375C File Offset: 0x002C195C
	public void e(int A_0)
	{
		if (this.e != A_0)
		{
			this.e = A_0;
			this.g();
		}
	}

	// Token: 0x0600689A RID: 26778 RVA: 0x002C3778 File Offset: 0x002C1978
	public string b()
	{
		return this.f;
	}

	// Token: 0x0600689B RID: 26779 RVA: 0x002C3780 File Offset: 0x002C1980
	public void a(string A_0)
	{
		if (this.f != A_0)
		{
			this.f = A_0;
			this.g();
		}
	}

	// Token: 0x0600689C RID: 26780 RVA: 0x002C37A0 File Offset: 0x002C19A0
	public bjp j()
	{
		return this.g;
	}

	// Token: 0x0600689D RID: 26781 RVA: 0x002C37A8 File Offset: 0x002C19A8
	public void a(bjp A_0)
	{
		if (this.g != A_0)
		{
			this.g = A_0;
			this.g();
		}
	}

	// Token: 0x0600689E RID: 26782 RVA: 0x002C37C4 File Offset: 0x002C19C4
	public bjp i()
	{
		return this.h;
	}

	// Token: 0x0600689F RID: 26783 RVA: 0x002C37CC File Offset: 0x002C19CC
	public void b(bjp A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.g();
		}
	}

	// Token: 0x060068A0 RID: 26784 RVA: 0x002C37E8 File Offset: 0x002C19E8
	public int h()
	{
		return this.j;
	}

	// Token: 0x060068A1 RID: 26785 RVA: 0x002C37F0 File Offset: 0x002C19F0
	public void c(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060068A2 RID: 26786 RVA: 0x002C37FC File Offset: 0x002C19FC
	public int m()
	{
		return this.k;
	}

	// Token: 0x060068A3 RID: 26787 RVA: 0x002C3804 File Offset: 0x002C1A04
	public void d(int A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060068A4 RID: 26788 RVA: 0x002C3810 File Offset: 0x002C1A10
	public Axis? e()
	{
		return this.l;
	}

	// Token: 0x060068A5 RID: 26789 RVA: 0x002C3818 File Offset: 0x002C1A18
	public void a(Axis? A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060068A6 RID: 26790 RVA: 0x002C3824 File Offset: 0x002C1A24
	public bvy(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060068A7 RID: 26791 RVA: 0x002C384C File Offset: 0x002C1A4C
	public void r7(eds A_0)
	{
		if (this.j != this.b || this.k != this.c)
		{
			if ((this.i += A_0.b.TotalMilliseconds) > (double)bvy.a)
			{
				this.i -= (double)bvy.a;
				int num;
				if (this.j < this.b || (this.j == this.b && this.k < this.c))
				{
					num = -1;
				}
				else
				{
					num = 1;
				}
				if (num == 1)
				{
					int num2 = this.c + 1;
					this.c = num2;
					if (num2 >= this.e)
					{
						this.c = 0;
						this.b++;
					}
				}
				else
				{
					int num2 = this.c - 1;
					this.c = num2;
					if (num2 < 0)
					{
						this.c = this.e - 1;
						this.b--;
					}
				}
				this.g();
			}
			this.a(true);
			return;
		}
		this.i = 0.0;
		this.a(false);
	}

	// Token: 0x060068A8 RID: 26792 RVA: 0x002C3984 File Offset: 0x002C1B84
	private List<b0b> a()
	{
		d60 addon = base.a8().Zone.GetAddon<d60>();
		List<b0b> list;
		if (addon != null)
		{
			list = addon.ab4(new string[]
			{
				this.f
			});
		}
		else
		{
			list = new List<b0b>();
			foreach (aud aud in base.a8().Zone.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					e3l aspect = c5x.GetAspect<e3l>();
					if (aspect != null && aspect.a.Contains(this.f))
					{
						list.Add(c5x);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060068A9 RID: 26793 RVA: 0x002C3A90 File Offset: 0x002C1C90
	public void g()
	{
		if (base.a8() != null && base.a8().Zone != null && !string.IsNullOrEmpty(this.f))
		{
			List<b0b> list = this.a();
			if (list != null && list.Count > 0)
			{
				bool a_ = this.b <= this.d;
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					this.a(c5x, a_);
					cge cge = c5x.o.b as cge;
					if (cge != null)
					{
						bool flag = true;
						int y = 0;
						if (this.b == cge.a())
						{
							y = 2;
						}
						else if (this.b == cge.a() - 1)
						{
							y = 1;
						}
						else if (this.b > cge.a())
						{
							flag = false;
						}
						if (flag)
						{
							c5x.ae = null;
						}
						else
						{
							c5x.ae = new float?(0f);
						}
						cge.b = new Point(this.c, y);
					}
				}
			}
		}
	}

	// Token: 0x060068AA RID: 26794 RVA: 0x002C3BEC File Offset: 0x002C1DEC
	private void a(c5x A_0, bool A_1)
	{
		A_0.TileFormationModifiers.c();
		if (A_1)
		{
			A_0.TileFormationModifiers.c(this.g.b);
		}
		else
		{
			A_0.TileFormationModifiers.c(this.h.b);
		}
		A_0.z();
		if (this.l != null && A_1)
		{
			clw clw = new clw();
			clw.a(new e6z(A_0.Area));
			clw.a(false);
			clw.a(this.l.Value);
			clw.a().Add(A_0.Location.a());
			d60 addon = base.a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					this.f
				});
				if (list != null && list.Count > 0)
				{
					foreach (b0b b0b in list)
					{
						clw.e().Add(b0b.qe());
					}
				}
			}
			A_0.Zone.ActionManager.g9(clw, atp.a);
		}
	}

	// Token: 0x060068AB RID: 26795 RVA: 0x002C3D3C File Offset: 0x002C1F3C
	private void a(bool A_0)
	{
		if (A_0)
		{
			aru aru = base.a8().c();
			SoundState? soundState = aru.b("ringGateControllerLoop");
			SoundState soundState2 = SoundState.Playing;
			if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
			{
				aru.a("ringGateControllerLoop", "HeavyGate", 1f, c9z.a, true, false);
				return;
			}
		}
		else
		{
			base.a8().c().a("ringGateControllerLoop", false);
		}
	}

	// Token: 0x04002B33 RID: 11059
	private static readonly int a = 150;

	// Token: 0x04002B34 RID: 11060
	private int b;

	// Token: 0x04002B35 RID: 11061
	private int c;

	// Token: 0x04002B36 RID: 11062
	private int d;

	// Token: 0x04002B37 RID: 11063
	private int e = 7;

	// Token: 0x04002B38 RID: 11064
	private string f;

	// Token: 0x04002B39 RID: 11065
	private bjp g = new bjp();

	// Token: 0x04002B3A RID: 11066
	private bjp h = new bjp();

	// Token: 0x04002B3B RID: 11067
	private double i;

	// Token: 0x04002B3C RID: 11068
	private int j;

	// Token: 0x04002B3D RID: 11069
	private int k;

	// Token: 0x04002B3E RID: 11070
	private Axis? l;
}
