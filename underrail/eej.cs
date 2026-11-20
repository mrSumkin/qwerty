using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000436 RID: 1078
[fe("todd")]
public sealed class eej : b5g
{
	// Token: 0x06001C46 RID: 7238 RVA: 0x00099A28 File Offset: 0x00097C28
	public eej(bm6 A_0) : base(A_0)
	{
		byh a_ = new byh("Jogging", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eej.c.a.a), null);
		aif aif = Enumerable.FirstOrDefault<aif>(Enumerable.OfType<aif>(base.g()));
		if (aif != null)
		{
			int num = base.g().IndexOf(aif);
			if (num >= 0)
			{
				base.a(num, a_);
			}
		}
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x00099AB8 File Offset: 0x00097CB8
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return !this.Subject.a8().h.b.aa().IsInCombat;
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x00099AE8 File Offset: 0x00097CE8
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.@as = new CharacterState?(CharacterState.Custom1);
		this.Subject.a8().h.b.ap = new CharacterState?(CharacterState.Custom3);
		return new eej.a().a(this);
	}

	// Token: 0x02000437 RID: 1079
	public new class a
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x00099B44 File Offset: 0x00097D44
		public cst a(ua A_0)
		{
			amc b = A_0.Subject.a8().h.b;
			mj b2 = A_0.Subject.a8().j.b;
			int num = b.aa().CustomProperties.GetPrimitivePropertyValue<int>(eej.b.d, new int?(1)).Value;
			bool flag = b.aa().CustomProperties.GetPrimitivePropertyValue<bool>(eej.b.e, new bool?(false)).Value;
			int num2 = b.aa().CustomProperties.GetPrimitivePropertyValue<int>(eej.b.c, new int?(1)).Value;
			if (flag)
			{
				if (num2 == 1)
				{
					if (--num <= 0)
					{
						num = eej.a.a;
					}
					num2 = -1;
				}
				else
				{
					if (++num > eej.a.a)
					{
						num = 1;
					}
					num2 = 1;
				}
				flag = false;
			}
			b.aa().CustomProperties[eej.b.d] = num;
			b.aa().CustomProperties[eej.b.e] = flag;
			b.aa().CustomProperties[eej.b.c] = num2;
			csd csd = A_0.Subject.a8().Zone.g("a" + num.ToString());
			if (csd != null)
			{
				Vector3 a_ = csd.Location;
				awx awx = new awx();
				awx.a(m7.b | m7.e);
				cy6 item = new cy6(b2, a_, null, m7.b | m7.e);
				int num3 = num + num2;
				if (num3 > eej.a.a)
				{
					num3 = 0;
				}
				if (num3 <= 0)
				{
					num3 = eej.a.a;
				}
				PropertyCollection propertyCollection = new PropertyCollection();
				propertyCollection[eej.b.d] = num3;
				awx.ad().Add(item);
				List<auv> list = awx.ad();
				afw afw = new afw();
				afw.a(propertyCollection);
				list.Add(new a4s(afw, null, new ar7(b.a8()), null));
				return awx;
			}
			return null;
		}

		// Token: 0x04000FB1 RID: 4017
		public static readonly int a = 4;
	}

	// Token: 0x02000438 RID: 1080
	public new static class b
	{
		// Token: 0x04000FB2 RID: 4018
		public static readonly string a = "IsJoggingProp";

		// Token: 0x04000FB3 RID: 4019
		public static readonly string b = "JogStepFailCount";

		// Token: 0x04000FB4 RID: 4020
		public static readonly string c = "CurrentDirection";

		// Token: 0x04000FB5 RID: 4021
		public static readonly string d = "CurrentStep";

		// Token: 0x04000FB6 RID: 4022
		public static readonly string e = "ReverseDirection";
	}

	// Token: 0x02000439 RID: 1081
	[CompilerGenerated]
	[Serializable]
	private new sealed class c
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x00099DA8 File Offset: 0x00097FA8
		internal float a(bool A_0)
		{
			return 0.505f;
		}

		// Token: 0x04000FB7 RID: 4023
		public static readonly eej.c a = new eej.c();

		// Token: 0x04000FB8 RID: 4024
		public static Func<bool, float> b;
	}
}
