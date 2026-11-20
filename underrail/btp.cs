using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x02000987 RID: 2439
[eiz("FOUFO5")]
[Serializable]
public sealed class btp : bdw, ISerializable
{
	// Token: 0x06003B17 RID: 15127 RVA: 0x0015E8D8 File Offset: 0x0015CAD8
	private btp(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x0015E8E0 File Offset: 0x0015CAE0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x0015E8E4 File Offset: 0x0015CAE4
	public btp()
	{
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x0015E8EC File Offset: 0x0015CAEC
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("fo5");
		if (aud != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_fo_meltedSupersteel", new bool?(false)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_fo_furnaceUpdatedForSupersteel", new bool?(false)).Value;
			if (value && !value2)
			{
				A_1.r()["loc_fo_furnaceUpdatedForSupersteel"] = true;
				for (int i = 21; i <= 27; i++)
				{
					for (int j = 13; j <= 15; j++)
					{
						this.a(aud, i, j);
					}
				}
				for (int k = 25; k <= 27; k++)
				{
					this.a(aud, k, 16);
				}
				c5x c5x = new ar7(new Guid("cf5b1a22-9867-4b0a-b73f-602006f21856"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"), aud).ao() as c5x;
				foreach (c5x c5x3 in new c5x[]
				{
					c5x,
					c5x2
				})
				{
					c5x3.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						1,
						2
					});
					c5x3.z();
					if (c5x3.o.b != null)
					{
						c5x3.o.b.b = Point.Zero;
					}
				}
				TypedObjectReference<b0b> typedObjectReference = new ar7(new Guid("ba0e1f12-cee3-463d-ae34-74acb6113adb"), aud);
				ar7 ar = new ar7(new Guid("a0dc74d6-8acd-439c-8b47-b0e51a695722"), aud);
				ar7 ar2 = new ar7(new Guid("5af048ef-9e0d-4fa1-812d-9db098621d08"), aud);
				c5x c5x4 = typedObjectReference.ao() as c5x;
				c5x c5x5 = ar.ao() as c5x;
				if (c5x4 != null && c5x4.o.b != null)
				{
					c5x4.o.b.b = new Point(7, 1);
				}
				if (c5x5 != null && c5x5.o.b != null)
				{
					c5x5.o.b.b = new Point(7, 1);
				}
				ah7 ah = A_0.i("metalIllumination");
				if (ah != null)
				{
					ah.Enabled = true;
					ae8 a_ = ah.Light;
					a_.a(0.7f);
					ah.Light = a_;
					ah.d();
				}
				bfq bfq = new bfq("bubbling", "LargeArcFurnaceBubbling");
				bfq.a(true);
				bfq.a(c9z.b);
				bfq.d(true);
				bfq.ym(null, ar2.ao(), null);
				for (int m = 2; m <= 4; m++)
				{
					doq a_2 = doq.a(Path.Combine(d5x.q(), "fo5_l" + m.ToString()) + ".uzl");
					A_0.a(a_2, 1, null);
				}
			}
			TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_fo_meltingFinishedTime", null);
			if (primitivePropertyValue != null && primitivePropertyValue.Value < A_1.p())
			{
				A_1.r()["loc_fo_supersteelMeltingInProcess"] = false;
				A_1.r()["loc_fo_supersteelWaitingForPickup"] = true;
				A_1.r().RemoveProperty("loc_fo_meltingFinishedTime");
			}
		}
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x0015EC54 File Offset: 0x0015CE54
	private void a(aud A_0, int A_1, int A_2)
	{
		ak1 ak = A_0.b(A_1, A_2);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == aju.x && !c5x.f && (c5x.o.b == null || !(c5x.o.b.a == "Floor\\LiquidMetal")) && c5x.Size.X < 2f)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
