using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x02000709 RID: 1801
public sealed class bbf : btu
{
	// Token: 0x06002EBD RID: 11965 RVA: 0x00108830 File Offset: 0x00106A30
	public void a()
	{
		if (!this.a)
		{
			bbf.b = new Dictionary<string, d6i>();
			this.a = true;
			foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(bbf.a.a.a)))
			{
				try
				{
					if (type.IsClass && !type.IsAbstract)
					{
						if (type.GetConstructor(Type.EmptyTypes) != null)
						{
							d6i d6i = (d6i)Activator.CreateInstance(type);
							if (!string.IsNullOrEmpty(d6i.mt()))
							{
								if (!bbf.b.ContainsKey(d6i.mt()))
								{
									bbf.b.Add(d6i.mt(), d6i);
								}
								else
								{
									dux.b(LogSeverity.Error, "ItemRandomizationManager: Duplicate item randomizer for item code '{0}': {1}.", new object[]
									{
										d6i.mt(),
										type.AssemblyQualifiedName
									});
								}
							}
							else
							{
								dux.b(LogSeverity.Error, "ItemRandomizationManager: Item randomizer '{0}' has empty target item code.", new object[]
								{
									type.AssemblyQualifiedName
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "ItemRandomizationManager: Failed to instantiate item randomizer '{0}'. Default constructor not found.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "ItemRandomizationManager: Failed to instantiate item randomizer '{0}'.", new object[]
					{
						type.AssemblyQualifiedName
					});
				}
			}
		}
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x001089E8 File Offset: 0x00106BE8
	public d6i wp(coh A_0)
	{
		this.a();
		if (A_0 != null && A_0.Definition != null && !string.IsNullOrEmpty(A_0.Definition.a5()))
		{
			d6i result;
			bbf.b.TryGetValue(A_0.Definition.a5(), out result);
			return result;
		}
		return null;
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x00108A3C File Offset: 0x00106C3C
	public void wq(coh A_0, int A_1)
	{
		this.a();
		try
		{
			d6i d6i = this.wp(A_0);
			if (d6i != null)
			{
				d6i.mw(A_0, A_1);
			}
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Error while randomizing item with code '{0}'.", new object[]
			{
				(A_0 != null && A_0.Definition != null) ? A_0.Definition.a5() : "(item or definition was null)"
			});
		}
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x00108ABC File Offset: 0x00106CBC
	public bool wr(coh A_0)
	{
		this.a();
		return this.wp(A_0) != null;
	}

	// Token: 0x040019FF RID: 6655
	private bool a;

	// Token: 0x04001A00 RID: 6656
	private static Dictionary<string, d6i> b;

	// Token: 0x0200070B RID: 1803
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002EC6 RID: 11974 RVA: 0x00108AE4 File Offset: 0x00106CE4
		internal bool a(Type A_0)
		{
			return typeof(d6i).IsAssignableFrom(A_0);
		}

		// Token: 0x04001A01 RID: 6657
		public static readonly bbf.a a = new bbf.a();

		// Token: 0x04001A02 RID: 6658
		public static Func<Type, bool> b;
	}
}
