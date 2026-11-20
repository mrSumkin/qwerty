using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x02000F92 RID: 3986
[eiz("DCPPRC")]
[Serializable]
public sealed class di2 : Aspect<c5x>, c98, chb
{
	// Token: 0x06005173 RID: 20851 RVA: 0x0024A464 File Offset: 0x00248664
	private di2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("DCPPRC:T");
		this.a = A_0.GetDouble("DCPPRC:C");
		this.c = A_0.GetBoolean("DCPPRC:E");
		this.f = A_0.GetBoolean("DCPPRC:S");
		this.h = (Rectangle)A_0.GetValue("DCPPRC:R", typeof(Rectangle));
		if (ell.a() >= 287)
		{
			this.i = (Guid)A_0.GetValue("DCPPRC:G", typeof(Guid));
		}
		if (ell.a() >= 288)
		{
			this.g = (Rectangle)A_0.GetValue("DCPPRC:X", typeof(Rectangle));
		}
		if (ell.a() >= 304)
		{
			this.j = (A_0.GetValue("DCPPRC:K", typeof(Guid?)) as Guid?);
		}
		di7.ReadList<Guid>("DCPPRC:I", ref this.d, A_0);
		di7.ReadDictionary<Guid, c5x>("DCPPRC:O", ref this.e, A_0);
		if (ell.a() >= 463)
		{
			this.k = A_0.GetString("DCPPRC:RC");
		}
	}

	// Token: 0x06005174 RID: 20852 RVA: 0x0024A5D0 File Offset: 0x002487D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCPPRC:T", this.b);
		info.AddValue("DCPPRC:C", this.a);
		info.AddValue("DCPPRC:E", this.c);
		info.AddValue("DCPPRC:S", this.f);
		info.AddValue("DCPPRC:R", this.h);
		info.AddValue("DCPPRC:G", this.i);
		info.AddValue("DCPPRC:K", this.j);
		info.AddValue("DCPPRC:X", this.g);
		di7.WriteList<Guid>("DCPPRC:I", this.d, info);
		di7.WriteDictionary<Guid, c5x>("DCPPRC:O", this.e, info);
		info.AddValue("DCPPRC:RC", this.k);
	}

	// Token: 0x06005175 RID: 20853 RVA: 0x0024A6B4 File Offset: 0x002488B4
	public bool k()
	{
		return this.c;
	}

	// Token: 0x06005176 RID: 20854 RVA: 0x0024A6BC File Offset: 0x002488BC
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005177 RID: 20855 RVA: 0x0024A6C8 File Offset: 0x002488C8
	public int i()
	{
		return this.b;
	}

	// Token: 0x06005178 RID: 20856 RVA: 0x0024A6D0 File Offset: 0x002488D0
	public List<Guid> j()
	{
		return this.d;
	}

	// Token: 0x06005179 RID: 20857 RVA: 0x0024A6D8 File Offset: 0x002488D8
	public void a(List<Guid> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600517A RID: 20858 RVA: 0x0024A6E4 File Offset: 0x002488E4
	public Rectangle g()
	{
		return this.h;
	}

	// Token: 0x0600517B RID: 20859 RVA: 0x0024A6EC File Offset: 0x002488EC
	public void b(Rectangle A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600517C RID: 20860 RVA: 0x0024A6F8 File Offset: 0x002488F8
	public Guid e()
	{
		return this.i;
	}

	// Token: 0x0600517D RID: 20861 RVA: 0x0024A700 File Offset: 0x00248900
	public void a(Guid A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600517E RID: 20862 RVA: 0x0024A70C File Offset: 0x0024890C
	public Guid? h()
	{
		return this.j;
	}

	// Token: 0x0600517F RID: 20863 RVA: 0x0024A714 File Offset: 0x00248914
	public void a(Guid? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005180 RID: 20864 RVA: 0x0024A720 File Offset: 0x00248920
	public Rectangle f()
	{
		return this.g;
	}

	// Token: 0x06005181 RID: 20865 RVA: 0x0024A728 File Offset: 0x00248928
	public void a(Rectangle A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005182 RID: 20866 RVA: 0x0024A734 File Offset: 0x00248934
	public string d()
	{
		return this.k;
	}

	// Token: 0x06005183 RID: 20867 RVA: 0x0024A73C File Offset: 0x0024893C
	public void a(string A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06005184 RID: 20868 RVA: 0x0024A748 File Offset: 0x00248948
	public di2(c5x A_0) : base(A_0)
	{
		this.a = 0.0;
	}

	// Token: 0x06005185 RID: 20869 RVA: 0x0024A780 File Offset: 0x00248980
	public void r7(eds A_0)
	{
		if (this.c && !dz6.e())
		{
			if ((this.a -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.a += (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.a = (double)d0u.b;
		}
	}

	// Token: 0x06005186 RID: 20870 RVA: 0x0024A7F4 File Offset: 0x002489F4
	public void c()
	{
		if (this.c)
		{
			this.a(true);
		}
	}

	// Token: 0x06005187 RID: 20871 RVA: 0x0024A80C File Offset: 0x00248A0C
	private void a(bool A_0 = false)
	{
		aud aud = base.a8().Area;
		c5x c5x = new ar7(this.i, aud).ao() as c5x;
		if (!this.f)
		{
			foreach (Guid guid in this.d)
			{
				c5x c5x2 = new ar7(guid, aud).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.an();
					this.e[guid] = (vq.a(c5x2) as c5x);
					aud.a(c5x2);
				}
			}
			if (!string.IsNullOrEmpty(this.k))
			{
				List<b0b> list = base.a8().Zone.a().ab4(new string[]
				{
					this.k
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						c5x c5x3 = (c5x)b0b;
						if (!this.e.ContainsKey(c5x3.qe()))
						{
							c5x3.an();
							this.e[c5x3.qe()] = (vq.a(c5x3) as c5x);
							aud.a(c5x3);
						}
					}
				}
			}
			this.f = true;
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dc_irisStatus");
		bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_iris_disableReinforcements", new bool?(false)).Value;
		if ((!(classPropertyValue == "disabled") || !(base.a8().Zone.y8() != "dc-pp_c")) && !value)
		{
			bool flag = false;
			foreach (KeyValuePair<Guid, c5x> keyValuePair in this.e)
			{
				if (!(new ar7(keyValuePair.Key, aud).ao() is c5x))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				int num = this.b + 1;
				this.b = num;
				if (num >= this.a())
				{
					this.b = 0;
					if (c5x != null && c5x.o.b != null && c5x.o.b.b.X == 0)
					{
						foreach (KeyValuePair<Guid, c5x> keyValuePair2 in this.e)
						{
							if (!(new ar7(keyValuePair2.Key, aud).ao() is c5x))
							{
								Vector3? vector = this.b();
								if (vector == null)
								{
									break;
								}
								c5x c5x4 = vq.a(keyValuePair2.Value) as c5x;
								c5x4.Layer = aju.x;
								c5x4.Location = vector.Value;
								ery aspect = c5x4.GetAspect<ery>();
								if (aspect != null)
								{
									aspect.e();
								}
								aud.a(c5x4);
							}
						}
					}
				}
			}
		}
		if (c5x != null && c5x.o.b != null && c5x.i.b != null)
		{
			bool flag2 = this.a(aud, this.h);
			bool flag3 = this.a(aud, this.g);
			if (flag2)
			{
				if (c5x.o.b.b.X != 3 && (c5x.i.b.a() == null || c5x.i.b.a().Name == "close"))
				{
					if (this.j == null || !c5x.o.b.a.StartsWith("Doors\\SplitGateSciFi", StringComparison.OrdinalIgnoreCase))
					{
						b6x b6x = new b6x();
						b6x.c().Add(this.i);
						b6x.a(aud.y8());
						b6x.a(bbo.b);
						b6x.ym(null, c5x, null);
						return;
					}
					c5x c5x5 = new ar7(this.j.Value, aud).ao() as c5x;
					if (c5x5 != null)
					{
						b6r b6r = new b6r();
						b6r.b(c5x.qe());
						b6r.a(c5x5.qe());
						b6r.b(aud.y8());
						b6r.a(bbo.b);
						b6r.ym(null, c5x, null);
						return;
					}
				}
			}
			else if (!flag3 && c5x.o.b.b.X != 0 && (c5x.i.b.a() == null || c5x.i.b.a().Name == "open"))
			{
				if (this.j != null && c5x.o.b.a.StartsWith("Doors\\SplitGateSciFi", StringComparison.OrdinalIgnoreCase))
				{
					c5x c5x6 = new ar7(this.j.Value, aud).ao() as c5x;
					if (c5x6 != null)
					{
						b6r b6r2 = new b6r();
						b6r2.b(c5x.qe());
						b6r2.a(c5x6.qe());
						b6r2.b(aud.y8());
						b6r2.a(bbo.c);
						b6r2.ym(null, c5x, null);
						return;
					}
				}
				else
				{
					b6x b6x2 = new b6x();
					b6x2.c().Add(this.i);
					b6x2.a(aud.y8());
					b6x2.a(bbo.c);
					b6x2.ym(null, c5x, null);
				}
			}
		}
	}

	// Token: 0x06005188 RID: 20872 RVA: 0x0024AE18 File Offset: 0x00249018
	private Vector3? b()
	{
		for (int i = this.h.X; i <= this.h.X + this.h.Width; i++)
		{
			for (int j = this.h.Y; j <= this.h.Y + this.h.Height; j++)
			{
				ak1 ak = base.a8().Area.b(i, j);
				if (ak != null && !aw1.a(null, ak, false, null))
				{
					return new Vector3?(ak.Location.a());
				}
			}
		}
		return null;
	}

	// Token: 0x06005189 RID: 20873 RVA: 0x0024AEC8 File Offset: 0x002490C8
	private bool a(aud A_0, Rectangle A_1)
	{
		for (int i = A_1.X; i <= A_1.X + A_1.Width; i++)
		{
			for (int j = A_1.Y; j <= A_1.Y + A_1.Height; j++)
			{
				ak1 ak = A_0.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !c5x.h.b.aa().Passive)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600518A RID: 20874 RVA: 0x0024AFB0 File Offset: 0x002491B0
	private int a()
	{
		switch (bpo.GetServiceOrThrow<bu6>().aq2())
		{
		case GameDifficulty.Easy:
			return 128;
		case GameDifficulty.Hard:
			return 24;
		case GameDifficulty.Dominating:
			return 12;
		}
		return 48;
	}

	// Token: 0x0400215F RID: 8543
	private double a;

	// Token: 0x04002160 RID: 8544
	private int b;

	// Token: 0x04002161 RID: 8545
	private bool c = true;

	// Token: 0x04002162 RID: 8546
	private List<Guid> d = new List<Guid>();

	// Token: 0x04002163 RID: 8547
	private Dictionary<Guid, c5x> e = new Dictionary<Guid, c5x>();

	// Token: 0x04002164 RID: 8548
	private bool f;

	// Token: 0x04002165 RID: 8549
	private Rectangle g;

	// Token: 0x04002166 RID: 8550
	private Rectangle h;

	// Token: 0x04002167 RID: 8551
	private Guid i;

	// Token: 0x04002168 RID: 8552
	private Guid? j;

	// Token: 0x04002169 RID: 8553
	private string k;
}
