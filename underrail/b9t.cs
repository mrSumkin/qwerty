using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001338 RID: 4920
[eiz("UOA")]
[Serializable]
public sealed class b9t : b1z, ISerializable
{
	// Token: 0x06006F77 RID: 28535 RVA: 0x002EC810 File Offset: 0x002EAA10
	private b9t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("UOA:IR", typeof(ar7));
			this.b = (EntityAspectReference<bim, bim>)A_0.GetValue("UOA:UR", typeof(EntityAspectReference<bim, bim>));
			if (ell.a() >= 213)
			{
				this.c = A_0.GetString("UOA:A");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(b9t))
			{
				this.a = (ar7)A_0.GetValue("_InitiatorRef", typeof(ar7));
				this.b = (EntityAspectReference<bim, bim>)A_0.GetValue("_UsableRef", typeof(EntityAspectReference<bim, bim>));
				return;
			}
			this.a = (ar7)A_0.GetValue("UseObjectAction+_InitiatorRef", typeof(ar7));
			this.b = (EntityAspectReference<bim, bim>)A_0.GetValue("UseObjectAction+_UsableRef", typeof(EntityAspectReference<bim, bim>));
		}
	}

	// Token: 0x06006F78 RID: 28536 RVA: 0x002EC92C File Offset: 0x002EAB2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UOA:IR", this.a);
		info.AddValue("UOA:UR", this.b);
		info.AddValue("UOA:A", this.c);
	}

	// Token: 0x06006F79 RID: 28537 RVA: 0x002EC974 File Offset: 0x002EAB74
	private c5x d()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x06006F7A RID: 28538 RVA: 0x002EC988 File Offset: 0x002EAB88
	private bim c()
	{
		return this.b.ao();
	}

	// Token: 0x06006F7B RID: 28539 RVA: 0x002EC998 File Offset: 0x002EAB98
	public string e()
	{
		return this.c;
	}

	// Token: 0x06006F7C RID: 28540 RVA: 0x002EC9A0 File Offset: 0x002EABA0
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006F7D RID: 28541 RVA: 0x002EC9AC File Offset: 0x002EABAC
	public b9t(c5x A_0, bim A_1, string A_2 = null)
	{
		this.a = new ar7(A_0);
		this.b = new EntityAspectReference<bim, bim>(A_1);
		this.c = A_2;
	}

	// Token: 0x06006F7E RID: 28542 RVA: 0x002EC9D4 File Offset: 0x002EABD4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.c() == null)
		{
			dux.b(LogSeverity.Error, "Failed to execute use object action. Usable was null.", new object[0]);
			return dc4.e;
		}
		if (this.d() == null)
		{
			dux.b(LogSeverity.Error, "Failed to execute use object action. Initiator was null.", new object[0]);
			return dc4.e;
		}
		if (!this.a())
		{
			bmj.a(this.c().a8(), new cwl());
			return dc4.e;
		}
		if (this.d().h.b != null && this.d().h.b.aa().IsInCombat && !this.c().af1())
		{
			if (this.d().h.b.aa() is e3q)
			{
				a7v.a(new vr(null, null, "Нельзя взаимодействовать с этим объектом во время боя.", new Color?(adi.l), null));
			}
			return dc4.e;
		}
		d2b d2b = null;
		if (this.c().a8() != null)
		{
			d2b = this.c().a8().GetAspect<d2b>();
		}
		if (d2b != null && this.d().h.b != null && d2b.n())
		{
			bool flag = (this.d().g & e2b.d) > (e2b)0;
			c9b c9b = d2b.a(this.d().h.b, false);
			switch (c9b)
			{
			case c9b.a:
				if (flag)
				{
					a7v.a(new jj());
					bmj.a(d2b.a8(), new d53("Открыто", adi.h, null, false));
					goto IL_28B;
				}
				goto IL_28B;
			case c9b.b:
			case c9b.c:
				if (flag)
				{
					aru aru = d2b.a8().c();
					if (aru != null)
					{
						aru.a("lock_unlock", (d2b.j() == LockType.Mechanical) ? "LockedMech" : "LockedDigi", 1f, c9z.a, false, false);
					}
					string text;
					if (!string.IsNullOrEmpty(d2b.i()))
					{
						text = d2b.i();
						if (d2b.e())
						{
							text += b9t.a(d2b);
						}
					}
					else
					{
						text = string.Format("Заперто{0}.", b9t.a(d2b));
					}
					a7v.a(new v4(text));
					bmj.a(d2b.a8(), new d53(text, adi.h, null, false));
				}
				return dc4.e;
			case c9b.d:
				return dc4.e;
			case c9b.e:
			case c9b.f:
				break;
			case c9b.g:
				bmj.a(d2b.a8(), new d53("Нет питания", adi.l, null, true));
				return dc4.e;
			default:
				if (c9b == c9b.h)
				{
					return dc4.e;
				}
				break;
			}
			return dc4.e;
		}
		IL_28B:
		if (this.c().a(this.d(), this.c, false, false))
		{
			dz6.a(this.d(), this.c());
		}
		return dc4.c;
	}

	// Token: 0x06006F7F RID: 28543 RVA: 0x002ECCA0 File Offset: 0x002EAEA0
	private int b()
	{
		if (this.c() != null)
		{
			return d0u.a()[this.c().pr()];
		}
		return 0;
	}

	// Token: 0x06006F80 RID: 28544 RVA: 0x002ECCC8 File Offset: 0x002EAEC8
	private bool a()
	{
		if (this.d() != null && this.d().h.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(this.d().h.b.aa());
				if (d4n != null)
				{
					int num = this.b();
					return d4n.c >= (double)num;
				}
			}
		}
		return true;
	}

	// Token: 0x06006F81 RID: 28545 RVA: 0x002ECD44 File Offset: 0x002EAF44
	private static string a(d2b A_0)
	{
		if (A_0.e())
		{
			string arg;
			if (A_0.j() == LockType.Electronic)
			{
				arg = "хакерство:";
			}
			else
			{
				arg = "взлом замка:";
			}
			return string.Format(" ({0} {1})", arg, A_0.p());
		}
		return string.Empty;
	}

	// Token: 0x04002D91 RID: 11665
	private new ar7 a;

	// Token: 0x04002D92 RID: 11666
	private EntityAspectReference<bim, bim> b;

	// Token: 0x04002D93 RID: 11667
	private string c;
}
