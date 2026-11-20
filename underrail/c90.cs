using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x020011A6 RID: 4518
public static class c90
{
	// Token: 0x06006046 RID: 24646 RVA: 0x0029FEEC File Offset: 0x0029E0EC
	public static void a(c5x A_0, c5k A_1)
	{
		if (A_0 == null || A_1 == null || A_1.f() == null)
		{
			return;
		}
		string classPropertyValue = A_1.f().GetClassPropertyValue<string>("Name");
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			A_0.q(classPropertyValue);
		}
		bool? primitivePropertyValue = A_1.f().GetPrimitivePropertyValue<bool>("IsGround", null);
		if (primitivePropertyValue != null)
		{
			A_0.IsGround = primitivePropertyValue.Value;
		}
		bool? primitivePropertyValue2 = A_1.f().GetPrimitivePropertyValue<bool>("IsFloor", null);
		if (primitivePropertyValue2 != null)
		{
			A_0.IsFloor = primitivePropertyValue2.Value;
		}
		string classPropertyValue2 = A_1.f().GetClassPropertyValue<string>("TileFormationModifiers");
		if (!string.IsNullOrEmpty(classPropertyValue2))
		{
			A_0.TileFormationModifiers = bjp.a(classPropertyValue2);
		}
		string classPropertyValue3 = A_1.f().GetClassPropertyValue<string>("FineSize");
		if (!string.IsNullOrEmpty(classPropertyValue3))
		{
			try
			{
				string[] array = classPropertyValue3.Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 2)
				{
					Vector2 value = new Vector2(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture));
					A_0.z = new Vector2?(value);
				}
			}
			catch
			{
			}
		}
		bool? primitivePropertyValue3 = A_1.f().GetPrimitivePropertyValue<bool>("ForwardOverlapping", null);
		if (primitivePropertyValue3 != null)
		{
			A_0.x = primitivePropertyValue3.Value;
		}
		string classPropertyValue4 = A_1.f().GetClassPropertyValue<string>("Color");
		if (!string.IsNullOrEmpty(classPropertyValue4))
		{
			try
			{
				A_0.ad = new Color?(zy.e(classPropertyValue4));
			}
			catch
			{
			}
		}
		A_0.ae = A_1.f().GetPrimitivePropertyValue<float>("Alpha", null);
		string classPropertyValue5 = A_1.f().GetClassPropertyValue<string>("Size");
		if (!string.IsNullOrEmpty(classPropertyValue5))
		{
			try
			{
				A_0.Size = zy.c(classPropertyValue5);
			}
			catch
			{
			}
		}
		int? primitivePropertyValue4 = A_1.f().GetPrimitivePropertyValue<int>("VisualPriority", null);
		if (primitivePropertyValue4 != null)
		{
			A_0.VisualPriority = primitivePropertyValue4.Value;
		}
		string classPropertyValue6 = A_1.f().GetClassPropertyValue<string>("VisualDirection");
		string.IsNullOrEmpty(classPropertyValue6);
		HorizontalDirection a_;
		if (Enum.TryParse<HorizontalDirection>(classPropertyValue6, out a_))
		{
			A_0.VisualDirection = a_;
		}
		bool? primitivePropertyValue5 = A_1.f().GetPrimitivePropertyValue<bool>("AutoUpdate", null);
		if (primitivePropertyValue5 != null && primitivePropertyValue5.Value)
		{
			a6p a6p = new a6p(A_0);
			a6p.a(A_1.c());
			string classPropertyValue7 = A_1.f().GetClassPropertyValue<string>("AutoUpdateFlags");
			if (!string.IsNullOrEmpty(classPropertyValue7))
			{
				foreach (string text in classPropertyValue7.Split(new string[]
				{
					","
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					a6p.d().Add(text.Trim());
				}
			}
			A_0.SetAspect<a6p>(a6p);
		}
		bool? primitivePropertyValue6 = A_1.f().GetPrimitivePropertyValue<bool>("ActionEntity", null);
		if (primitivePropertyValue6 != null && primitivePropertyValue6.Value && A_0.GetAspect<ny>() == null)
		{
			ny aspect = new ny(A_0);
			A_0.SetAspect<ny>(aspect);
		}
		int? primitivePropertyValue7 = A_1.f().GetPrimitivePropertyValue<int>("WarmthSource", null);
		if (primitivePropertyValue7 != null && primitivePropertyValue7.Value > 0)
		{
			a2r a2r = A_0.GetAspect<a2r>();
			if (a2r == null)
			{
				a2r = new a2r(A_0);
				A_0.SetAspect<a2r>(a2r);
			}
			a2r.a((float)primitivePropertyValue7.Value);
		}
		if (A_1.f().GetPrimitivePropertyValue<bool>("AudioSource", null).GetValueOrDefault())
		{
			aru aru = new aru(A_0);
			A_0.SetAspect<aru>(aru);
			string classPropertyValue8 = A_1.f().GetClassPropertyValue<string>("LoopingSounds");
			if (!string.IsNullOrEmpty(classPropertyValue8))
			{
				string[] array2 = classPropertyValue8.Split(new string[]
				{
					","
				}, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array3 = array2[i].Split(new string[]
					{
						"="
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array3.Length >= 2)
					{
						string[] array4 = array3[1].Split(new string[]
						{
							"|"
						}, StringSplitOptions.RemoveEmptyEntries);
						if (array4.Length != 0)
						{
							c9z a_2 = c9z.a;
							if (array4.Length > 1)
							{
								try
								{
									Enum.TryParse<c9z>(array4[1], out a_2);
								}
								catch
								{
								}
							}
							Dictionary<string, app> dictionary = aru.e();
							string key = array3[0];
							app app = new app();
							app.a(array4[0]);
							app.a(a_2);
							app.b(true);
							dictionary[key] = app;
						}
					}
				}
			}
		}
		string classPropertyValue9 = A_1.f().GetClassPropertyValue<string>("CustomFlags");
		e2b e2b;
		if (!string.IsNullOrEmpty(classPropertyValue9) && Enum.TryParse<e2b>(classPropertyValue9, out e2b))
		{
			A_0.ab |= e2b;
		}
		if (A_1.f().GetPrimitivePropertyValue<bool>("Usable", new bool?(false)).Value && A_0.GetAspect<bim>() == null)
		{
			bim bim = new bim(A_0);
			A_0.SetAspect<bim>(bim);
			c90.a(bim, A_1);
		}
		string classPropertyValue10 = A_1.f().GetClassPropertyValue<string>("RegistryCategories");
		if (!string.IsNullOrWhiteSpace(classPropertyValue10))
		{
			string[] array5 = classPropertyValue10.Split(new char[]
			{
				','
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array5.Length != 0)
			{
				e3l e3l = new e3l(A_0);
				e3l.a.AddRange(array5);
				A_0.SetAspect<e3l>(e3l);
			}
		}
		bool? primitivePropertyValue8 = A_1.f().GetPrimitivePropertyValue<bool>("DesignOnly", null);
		if (primitivePropertyValue8 != null)
		{
			A_0.aa = primitivePropertyValue8.Value;
		}
	}

	// Token: 0x06006047 RID: 24647 RVA: 0x002A0554 File Offset: 0x0029E754
	public static void a(bim A_0, c5k A_1)
	{
		if (A_0 == null || A_1 == null || A_1.f() == null)
		{
			return;
		}
		bool? primitivePropertyValue = A_1.f().GetPrimitivePropertyValue<bool>("OrientationBasedApproachableDirection", null);
		if (primitivePropertyValue != null)
		{
			A_0.f(primitivePropertyValue.Value);
		}
		string classPropertyValue = A_1.f().GetClassPropertyValue<string>("ApproachableDirections");
		if (string.IsNullOrEmpty(classPropertyValue))
		{
			A_0.a(null);
		}
		else
		{
			List<HorizontalDirection> list = new List<HorizontalDirection>();
			foreach (string text in classPropertyValue.Split(new char[]
			{
				','
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				try
				{
					HorizontalDirection item = (HorizontalDirection)Enum.Parse(typeof(HorizontalDirection), text.Trim());
					list.Add(item);
				}
				catch
				{
				}
			}
			if (list.Count > 0)
			{
				A_0.a(list);
			}
			else
			{
				A_0.a(null);
			}
		}
		A_0.j(A_1.GetParam<bool>("ForceUserOutsideBoundaries"));
		int param = A_1.GetParam<int>("Usable.OnUsedJobCount");
		if (param > 0)
		{
			List<cze> collection = c90.a(A_1, "Usable.OnUsedJobs", param);
			A_0.s().AddRange(collection);
		}
	}

	// Token: 0x06006048 RID: 24648 RVA: 0x002A06B0 File Offset: 0x0029E8B0
	public static void a(b0e A_0, c5k A_1)
	{
		if (A_0 == null || A_1 == null || A_1.f() == null)
		{
			return;
		}
		A_0.c(A_1.f().GetClassPropertyValue<string>("OpenSound"));
		A_0.d(A_1.f().GetClassPropertyValue<string>("CloseSound"));
	}

	// Token: 0x06006049 RID: 24649 RVA: 0x002A0704 File Offset: 0x0029E904
	public static cd0 a(c5x A_0, c5k A_1, string A_2)
	{
		cd0 cd = null;
		string classPropertyValue = A_1.f().GetClassPropertyValue<string>(A_2 + "SimpleType");
		if (!(classPropertyValue == "TwoOrientations"))
		{
			if (!(classPropertyValue == "FourOrientations"))
			{
				if (!(classPropertyValue == "EightOrientations"))
				{
					if (!(classPropertyValue == "SimpleAnimation"))
					{
						cd = new cd0(A_0);
					}
					else
					{
						etz etz = new etz(A_0);
						cd = etz;
						int? primitivePropertyValue = A_1.f().GetPrimitivePropertyValue<int>(A_2 + "AnimationStart", null);
						if (primitivePropertyValue != null)
						{
							etz.a(primitivePropertyValue.Value);
						}
						int? primitivePropertyValue2 = A_1.f().GetPrimitivePropertyValue<int>(A_2 + "StepChange", null);
						if (primitivePropertyValue2 != null)
						{
							etz.b(primitivePropertyValue2.Value);
						}
						int? primitivePropertyValue3 = A_1.f().GetPrimitivePropertyValue<int>(A_2 + "TotalSteps", null);
						if (primitivePropertyValue3 != null)
						{
							etz.c(primitivePropertyValue3.Value);
						}
						int? primitivePropertyValue4 = A_1.f().GetPrimitivePropertyValue<int>(A_2 + "StepDuration", null);
						if (primitivePropertyValue4 != null)
						{
							etz.d(primitivePropertyValue4.Value);
						}
						etz.b(A_1.f().GetPrimitivePropertyValue<int>(A_2 + "FrameWrap", null));
						bool? primitivePropertyValue5 = A_1.f().GetPrimitivePropertyValue<bool>(A_2 + "OffsetAnimation", null);
						if (primitivePropertyValue5 != null)
						{
							etz.a(primitivePropertyValue5.Value);
						}
					}
				}
				else
				{
					cd = new a2o(A_0);
				}
			}
			else
			{
				cd = new e4x(A_0);
			}
		}
		else
		{
			cd = new ask(A_0);
		}
		cd.a = A_1.f().GetClassPropertyValue<string>(A_2 + "Model");
		string classPropertyValue2 = A_1.f().GetClassPropertyValue<string>(A_2 + "Frame");
		if (!string.IsNullOrEmpty(classPropertyValue2))
		{
			cd.b = zy.b(classPropertyValue2);
		}
		cd.d(A_1.f().GetPrimitivePropertyValue<int>(A_2 + "RowWrap", null));
		cd.b(A_1.f().GetPrimitivePropertyValue<bool>(A_2 + "RowWrapOnLogicalShift", new bool?(false)).Value);
		string classPropertyValue3 = A_1.f().GetClassPropertyValue<string>(A_2 + "SimpleAspectColor");
		if (!string.IsNullOrEmpty(classPropertyValue3))
		{
			try
			{
				cd.c = new Color?(zy.e(classPropertyValue3));
			}
			catch
			{
			}
		}
		cd.d = A_1.f().GetPrimitivePropertyValue<float>(A_2 + "SimpleAspectAlpha", null);
		cd.h = A_1.f().GetPrimitivePropertyValue<bool>(A_2 + "DesignOnly", new bool?(false)).Value;
		cd.g = A_1.f().GetPrimitivePropertyValue<float>(A_2 + "SimpleAspectEmission", null);
		return cd;
	}

	// Token: 0x0600604A RID: 24650 RVA: 0x002A0A58 File Offset: 0x0029EC58
	public static void a(c5x A_0, c5k A_1, bdi A_2)
	{
		bool? primitivePropertyValue = A_1.f().GetPrimitivePropertyValue<bool>("IsProjectile", null);
		if (primitivePropertyValue != null && primitivePropertyValue.Value)
		{
			float? primitivePropertyValue2 = A_1.f().GetPrimitivePropertyValue<float>("Speed", null);
			int? primitivePropertyValue3 = A_1.f().GetPrimitivePropertyValue<int>("Frames", null);
			float? primitivePropertyValue4 = A_1.f().GetPrimitivePropertyValue<float>("MovementPhaseStep", null);
			b4u b4u = new b4u(A_0, A_2, primitivePropertyValue2.GetValueOrDefault(30f), primitivePropertyValue3.GetValueOrDefault(5), primitivePropertyValue4.GetValueOrDefault(100f));
			A_0.SetAspect<b4u>(b4u);
			mj mj = new mj(A_0, new MobileEntityAspectAccessor<b4u>(A_0));
			mj.a(b4u);
			A_0.SetAspect<mj>(mj);
		}
	}

	// Token: 0x0600604B RID: 24651 RVA: 0x002A0B38 File Offset: 0x0029ED38
	public static List<cze> a(c5k A_0, string A_1, int A_2)
	{
		List<cze> list = new List<cze>();
		for (int i = 0; i < A_2; i++)
		{
			string classPropertyValue = A_0.f().GetClassPropertyValue<string>(A_1 + "." + i.ToString());
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string[] array = classPropertyValue.Split(new char[]
				{
					':'
				});
				if (array.Length == 2)
				{
					string text = array[0];
					string s = array[1];
					Type type = dds.a.av3(text, "X", false);
					if (type != null && typeof(cze).IsAssignableFrom(type) && type.IsClass && !type.IsAbstract)
					{
						int num;
						int.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out num);
						if (num < 0)
						{
							goto IL_17E;
						}
						object[] array2 = new object[num];
						for (int j = 0; j < num; j++)
						{
							array2[j] = A_0.f().GetPropertyValue(string.Concat(new string[]
							{
								A_1,
								".",
								i.ToString(),
								".",
								j.ToString()
							}));
						}
						try
						{
							cze item = Activator.CreateInstance(type, array2) as cze;
							list.Add(item);
							goto IL_17E;
						}
						catch (Exception a_)
						{
							dux.a(LogSeverity.Error, a_, "Failed to instantiate job of type '{0}'.", new object[]
							{
								text
							});
							goto IL_17E;
						}
					}
					dux.b(LogSeverity.Error, "Failed to retrieve job of type '{0}'.", new object[]
					{
						text
					});
				}
			}
			IL_17E:;
		}
		return list;
	}
}
