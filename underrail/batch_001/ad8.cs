using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020009C2 RID: 2498
[eiz("LUMTAC2")]
[Serializable]
public sealed class ad8 : bdw, ISerializable
{
	// Token: 0x06003C04 RID: 15364 RVA: 0x00162DDC File Offset: 0x00160FDC
	private ad8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C05 RID: 15365 RVA: 0x00162DE4 File Offset: 0x00160FE4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C06 RID: 15366 RVA: 0x00162DE8 File Offset: 0x00160FE8
	public ad8()
	{
	}

	// Token: 0x06003C07 RID: 15367 RVA: 0x00162DF4 File Offset: 0x00160FF4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b29");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("4dbe82fa-49e8-47a5-a998-d0ad3b02c09a"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("a33996dc-c385-4bfa-b955-0d01f49c5883"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("e48d7dee-bf46-4a55-ab4a-69539c146556"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("528dde15-10e4-4435-836a-349b62dca5ff"), aud).ao() as c5x;
				if (c5x != null && c5x2 != null && c5x3 != null && c5x4 != null)
				{
					c5x.w();
					c5x.an();
					c5x2.w();
					c5x2.an();
					c5x3.w();
					c5x3.an();
					c5x4.w();
					c5x4.an();
				}
				c5x c5x5 = new ar7(new Guid("59c9c8dc-4ef5-499a-8ffa-bc7221fce778"), aud).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("0214ef99-3246-4605-ac43-0a810540716a"), aud).ao() as c5x;
				c5x c5x7 = new ar7(new Guid("8865b6de-0ddb-46f1-8ccc-4ac7034d913c"), aud).ao() as c5x;
				c5x c5x8 = new ar7(new Guid("d2b25e64-9b02-46a8-855a-98f9e179871d"), aud).ao() as c5x;
				c5x c5x9 = new ar7(new Guid("7e460ea2-84ab-4a93-a599-5168924a2691"), aud).ao() as c5x;
				ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(aud.Triggers, new Func<ya, bool>(ad8.a.a.a)));
				if (c5x5 != null)
				{
					c5x5.w();
					c5x5.an();
				}
				if (c5x6 != null)
				{
					c5x6.w();
					c5x6.an();
				}
				if (c5x7 != null)
				{
					c5x7.w();
					c5x7.an();
				}
				if (c5x8 != null)
				{
					c5x8.w();
					c5x8.an();
				}
				if (c5x9 != null)
				{
					c5x9.w();
					c5x9.an();
				}
				if (ya != null)
				{
					ya.o();
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x10 = (c5x)b0b;
					if (c5x10.s.b != null)
					{
						c7j c7j = c5x10.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							c7j.ItemContainer.z7();
						}
					}
				}
			}
		}
	}

	// Token: 0x020009C3 RID: 2499
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003C0A RID: 15370 RVA: 0x001630AC File Offset: 0x001612AC
		internal bool a(ya A_0)
		{
			return A_0.Name == "FreeDronesTerritory";
		}

		// Token: 0x04001B96 RID: 7062
		public static readonly ad8.a a = new ad8.a();

		// Token: 0x04001B97 RID: 7063
		public static Func<ya, bool> b;
	}
}
