using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E91 RID: 3729
[e79("Rc_SettingUpEmpEmitter")]
public sealed class db1 : dgy
{
	// Token: 0x06004D60 RID: 19808 RVA: 0x00222828 File Offset: 0x00220A28
	public db1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			db1.a a = new db1.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.c = (new ar7(new Guid("b3fc8520-0419-4f38-b8bc-98054525e3ea"), a.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("2b8a9089-1db2-4f4d-9432-d54c7229d592"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "empEmitter"
						})
						{
							InitiatorRef = new ar7(a.b)
						}
					});
				}
				if (a.c != null)
				{
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "myles2"
						})
						{
							InitiatorRef = new ar7(a.c)
						}
					});
				}
				base.a(new btm[]
				{
					new ace(new be6
					{
						DestinationWaypoint = "playerInEmpCutscene"
					})
					{
						InitiatorRef = new ar7(a.a)
					}
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = true;
				array2[num2] = c8s;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Operating);
				bb.a(atp.a);
				bb.IsAsync = false;
				bb.a(new ar7(a.c));
				bb.b(5);
				array3[num3] = bb;
				base.a(array3);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E92 RID: 3730
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D62 RID: 19810 RVA: 0x00222AC0 File Offset: 0x00220CC0
		internal bool b(e6d A_0)
		{
			if (this.b != null && this.b.o.b != null)
			{
				this.b.o.b.b = new Point(1, this.b.o.b.b.Y);
				ah7 ah = this.b.Zone.i("EmpDevice");
				if (ah != null && ah.Layer == this.b.Layer)
				{
					ah.g().be(this.b);
				}
			}
			return true;
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00222B68 File Offset: 0x00220D68
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F9C RID: 8092
		public c5x a;

		// Token: 0x04001F9D RID: 8093
		public c5x b;

		// Token: 0x04001F9E RID: 8094
		public c5x c;
	}
}
