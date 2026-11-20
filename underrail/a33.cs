using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020005BD RID: 1469
public sealed class a33 : ae1
{
	// Token: 0x0600271D RID: 10013 RVA: 0x000E397C File Offset: 0x000E1B7C
	public override string gr()
	{
		return "statusEffect";
	}

	// Token: 0x0600271E RID: 10014 RVA: 0x000E3988 File Offset: 0x000E1B88
	public override object gs(string A_0)
	{
		Type type = Type.GetType("TimelapseVertigo.Rules.Effects.StatusEffects." + A_0);
		if (type != null)
		{
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				return constructor.Invoke(null);
			}
			constructor = type.GetConstructor(new Type[]
			{
				typeof(int)
			});
			if (constructor != null)
			{
				return constructor.Invoke(new object[]
				{
					0
				});
			}
		}
		return null;
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x000E3A10 File Offset: 0x000E1C10
	protected override List<object> gt()
	{
		List<Type> list = bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(a33.a.a.a));
		List<object> list2 = new List<object>();
		foreach (Type type in list)
		{
			list2.Add(type.Name);
		}
		return list2;
	}

	// Token: 0x020005BE RID: 1470
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06002723 RID: 10019 RVA: 0x000E3AB8 File Offset: 0x000E1CB8
		internal bool a(Type A_0)
		{
			return !A_0.IsAbstract && typeof(els).IsAssignableFrom(A_0);
		}

		// Token: 0x0400163C RID: 5692
		public static readonly a33.a a = new a33.a();

		// Token: 0x0400163D RID: 5693
		public static Func<Type, bool> b;
	}
}
