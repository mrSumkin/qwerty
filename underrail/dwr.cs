using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000AEB RID: 2795
[eiz("XPBLUPDHMCGRJ")]
[Serializable]
public sealed class dwr : cze, ISerializable
{
	// Token: 0x060040F9 RID: 16633 RVA: 0x0018C474 File Offset: 0x0018A674
	private dwr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPBLUPDHMCGRJ:RR");
	}

	// Token: 0x060040FA RID: 16634 RVA: 0x0018C490 File Offset: 0x0018A690
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLUPDHMCGRJ:RR", this.a);
	}

	// Token: 0x060040FB RID: 16635 RVA: 0x0018C4AC File Offset: 0x0018A6AC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060040FC RID: 16636 RVA: 0x0018C4B4 File Offset: 0x0018A6B4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040FD RID: 16637 RVA: 0x0018C4C0 File Offset: 0x0018A6C0
	public dwr()
	{
	}

	// Token: 0x060040FE RID: 16638 RVA: 0x0018C4CC File Offset: 0x0018A6CC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"mutant"
				}))
				{
					c5x c5x = (c5x)b0b;
					a6p aspect = c5x.GetAspect<a6p>();
					if (aspect != null)
					{
						if (this.a)
						{
							aspect.d().AddRange(new string[]
							{
								"-inventory",
								"-gear"
							});
						}
						else
						{
							aspect.d().RemoveAll(new Predicate<string>(dwr.a.a.a));
						}
					}
					if (c5x.h.b != null)
					{
						cgk cgk = c5x.h.b.aa().Gear.l().Item;
						if (cgk != null && this.a)
						{
							using (List<d3e>.Enumerator enumerator2 = Enumerable.ToList<d3e>(cgk.fu().ar()).GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.GetType() == typeof(e3r))
									{
										return;
									}
								}
							}
							cgk.fu().ar().Add(new e3r(DamageType.Cold, 6.0));
							c5x.h.b.aa().Gear.l().po(cgk.fy());
						}
					}
				}
			}
		}
	}

	// Token: 0x04001C0D RID: 7181
	private new bool a;

	// Token: 0x02000AEC RID: 2796
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004101 RID: 16641 RVA: 0x0018C6E8 File Offset: 0x0018A8E8
		internal bool a(string A_0)
		{
			return A_0 == "-inventory" || A_0 == "-gear";
		}

		// Token: 0x04001C0E RID: 7182
		public static readonly dwr.a a = new dwr.a();

		// Token: 0x04001C0F RID: 7183
		public static Predicate<string> b;
	}
}
