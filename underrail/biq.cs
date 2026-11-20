using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000B7F RID: 2943
[eiz("CAFSK")]
[Serializable]
public sealed class biq : cze, ISerializable
{
	// Token: 0x06004334 RID: 17204 RVA: 0x001A4774 File Offset: 0x001A2974
	private biq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x001A4780 File Offset: 0x001A2980
	public biq()
	{
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x001A4788 File Offset: 0x001A2988
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		d02 service = bpo.GetService<d02>();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (service != null && !service.ahg() && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Zone != null && !serviceOrThrow.aqu().v().Dead)
		{
			List<efk> list = Enumerable.ToList<efk>(Enumerable.Select<d4n, efk>(Enumerable.Where<d4n>(service.ahl(), new Func<d4n, bool>(biq.a.a.a)), new Func<d4n, efk>(biq.a.a.b)));
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b.a8().Location.X >= 10f && d4n.b.a8().Location.Y >= 10f && !d4n.b.aa().Passive)
				{
					using (List<efk>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.a(serviceOrThrow.aqu().ac(), d4n.b.aa().FactionId) == h.a)
							{
								return;
							}
						}
					}
				}
			}
			if (A_0 != null)
			{
				a3f aspect = A_0.GetAspect<a3f>();
				if (aspect != null)
				{
					string classPropertyValue = aspect.a().GetClassPropertyValue<string>("EndCutsceneName");
					if (!string.IsNullOrWhiteSpace(classPropertyValue))
					{
						foreach (els els in Enumerable.ToList<els>(serviceOrThrow.aqu().v().StatusEffects.d()))
						{
							if (Enumerable.Any<vf>(Enumerable.OfType<vf>(els.DynamicEffects)))
							{
								serviceOrThrow.aqu().v().StatusEffects.d(els);
							}
						}
						aspect.a().RemoveProperty("EndCutsceneName");
						bpo.GetServiceOrThrow<ps>().am3("Arena/" + classPropertyValue);
					}
				}
			}
		}
	}

	// Token: 0x02000B80 RID: 2944
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004339 RID: 17209 RVA: 0x001A4A68 File Offset: 0x001A2C68
		internal bool a(d4n A_0)
		{
			return A_0.b.aa().FactionId == asp.ep || A_0.b.aa().FactionId == asp.eq || A_0.b.aa().FactionId == asp.e || A_0.b.aa().FactionId == asp.av || A_0.b.aa().FactionId == asp.ax || A_0.b.aa().FactionId == asp.ay || A_0.b.aa().FactionId == asp.@as;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x001A4B4C File Offset: 0x001A2D4C
		internal efk b(d4n A_0)
		{
			return A_0.b.aa();
		}

		// Token: 0x04001C38 RID: 7224
		public static readonly biq.a a = new biq.a();

		// Token: 0x04001C39 RID: 7225
		public static Func<d4n, bool> b;

		// Token: 0x04001C3A RID: 7226
		public static Func<d4n, efk> c;
	}
}
