using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x0200012C RID: 300
public class a4q : cne
{
	// Token: 0x06000721 RID: 1825 RVA: 0x0001CF8C File Offset: 0x0001B18C
	internal a4q(ContentManager A_0)
	{
		czh.a(A_0, "contentManager");
		this.c = A_0;
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
	public T GetResource<T>(string assetName, double? idleLimit = null) where T : class
	{
		double num = idleLimit ?? this.uu();
		b5s b5s = null;
		T result = default(T);
		b5s b5s2;
		this.a.TryGetValue(assetName, out b5s2);
		if (b5s2 == null)
		{
			b5s2 = new b5s();
			b5s2.a = num;
			b5s2.c = num;
			b5s = b5s2;
		}
		if (b5s2.b == null)
		{
			b5s2.b = (result = this.LoadResource<T>(assetName));
		}
		else
		{
			result = (b5s2.b as T);
		}
		if (b5s2.b != null && b5s2.c != -1.0)
		{
			b5s2.c = num;
			b5s2.a = num;
		}
		if (b5s != null)
		{
			this.a.Add(assetName, b5s);
		}
		return result;
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
	public Texture2D us(string A_0, double? A_1 = null)
	{
		double num = A_1 ?? this.uu();
		b5s b5s = null;
		b5s b5s2;
		this.a.TryGetValue(A_0, out b5s2);
		if (b5s2 == null)
		{
			b5s2 = new b5s();
			b5s2.a = num;
			b5s2.c = num;
			b5s = b5s2;
		}
		Texture2D result;
		if (b5s2.b == null)
		{
			result = (b5s2.b = this.LoadResource<Texture2D>(A_0));
		}
		else
		{
			result = (b5s2.b as Texture2D);
		}
		if (b5s2.b != null && b5s2.c != -1.0)
		{
			b5s2.c = num;
			b5s2.a = num;
		}
		if (b5s != null)
		{
			this.a.Add(A_0, b5s);
		}
		return result;
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x0001D190 File Offset: 0x0001B390
	public bool ut(string A_0)
	{
		if (this.a.ContainsKey(A_0))
		{
			b5s b5s = this.a[A_0];
			if (b5s != null)
			{
				b5s.a = 0.0;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
	public double uu()
	{
		return this.i;
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x0001D1DC File Offset: 0x0001B3DC
	public void uv(double A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
	public bool uw()
	{
		return this.j;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
	public void ux(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x0001D1FC File Offset: 0x0001B3FC
	public void uy()
	{
		this.b.Clear();
		List<Tuple<string, b5s, Type>> list = new List<Tuple<string, b5s, Type>>();
		foreach (KeyValuePair<string, b5s> keyValuePair in new Dictionary<string, b5s>(this.a))
		{
			if (keyValuePair.Value.b != null)
			{
				list.Add(new Tuple<string, b5s, Type>(keyValuePair.Key, keyValuePair.Value, keyValuePair.Value.b.GetType()));
			}
			this.ut(keyValuePair.Key);
		}
		this.uz(true);
		foreach (Tuple<string, b5s, Type> tuple in list)
		{
			try
			{
				MethodInfo methodInfo = base.GetType().GetMethod("GetResource", BindingFlags.Instance | BindingFlags.Public).MakeGenericMethod(new Type[]
				{
					tuple.Item3
				});
				if (methodInfo != null)
				{
					methodInfo.Invoke(this, new object[]
					{
						tuple.Item1,
						tuple.Item2.c
					});
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x0001D36C File Offset: 0x0001B56C
	public void uz(bool A_0 = false)
	{
		foreach (b5s b5s in this.a.Values)
		{
			if (b5s.b != null && (A_0 || b5s.c != -1.0) && b5s.a <= 0.0)
			{
				Texture2D texture2D = b5s.b as Texture2D;
				if (texture2D != null)
				{
					this.a(texture2D);
				}
				a4q.a(b5s);
			}
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x0001D41C File Offset: 0x0001B61C
	public void a(GameTime A_0)
	{
		foreach (b5s b5s in this.a.Values)
		{
			if (b5s.b != null && b5s.c != -1.0)
			{
				if (b5s.a > 0.0)
				{
					b5s.a -= A_0.ElapsedGameTime.TotalMilliseconds;
				}
				if (this.j && b5s.a <= 0.0)
				{
					a4q.a(b5s);
				}
			}
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x0001D4EC File Offset: 0x0001B6EC
	public void b()
	{
		foreach (b5s a_ in this.a.Values)
		{
			a4q.a(a_);
		}
		this.u2();
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x0001D550 File Offset: 0x0001B750
	public ecg u0(Texture2D A_0)
	{
		if (A_0 != null && this.d != null)
		{
			ecg result;
			this.d.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x0001D580 File Offset: 0x0001B780
	public void u1()
	{
		foreach (KeyValuePair<string, b5s> keyValuePair in this.a)
		{
			Texture2D texture2D = keyValuePair.Value.b as Texture2D;
			if (texture2D != null)
			{
				this.a(texture2D, keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x0001D5FC File Offset: 0x0001B7FC
	public void u2()
	{
		this.d = null;
		this.e = null;
		if (this.g != null && this.g.Length != 0)
		{
			for (int i = 0; i < this.g.Length; i++)
			{
				try
				{
					FileStream fileStream = this.g[i];
					if (fileStream != null)
					{
						fileStream.Close();
					}
				}
				catch
				{
				}
				finally
				{
					this.g[i] = null;
				}
			}
			this.g = null;
		}
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x0001D69C File Offset: 0x0001B89C
	private T LoadResource<T>(string assetName) where T : class
	{
		if (string.IsNullOrEmpty(assetName))
		{
			return default(T);
		}
		if (!this.b.Contains(assetName))
		{
			try
			{
				T t = this.c.Load<T>(assetName);
				Texture2D texture2D = t as Texture2D;
				if (texture2D != null)
				{
					this.a(texture2D, assetName);
				}
				return t;
			}
			catch (Exception ex)
			{
				if (!(ex is OutOfMemoryException))
				{
					this.b.Add(assetName);
				}
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 111))
				{
					string a_ = ki.a("[Dynamic Resource Manager] - Resource with asset name '{0}' failed to load and has been marked as invalid. Exception: {1}.", new object[]
					{
						assetName,
						ex
					});
					cvq.n7(LogSeverity.Warning, 111, a_);
				}
				return default(T);
			}
		}
		return default(T);
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x0001D78C File Offset: 0x0001B98C
	private ecg a(Texture2D A_0, string A_1)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_1))
		{
			if (this.d == null)
			{
				this.a();
			}
			if (this.d != null)
			{
				ecg ecg;
				if (!this.d.TryGetValue(A_0, out ecg))
				{
					fu fu;
					if (this.e.TryGetValue(A_1.ToLowerInvariant(), out fu))
					{
						if (this.g[fu.c] == null && this.h != null && this.h.Length > fu.c)
						{
							this.g[fu.c] = File.OpenRead(this.h[fu.c]);
						}
						try
						{
							this.g[fu.c].Position = this.f[fu.c] + fu.a;
							ecg = ecg.a(this.g[fu.c]);
							this.d[A_0] = ecg;
							return ecg;
						}
						catch (Exception)
						{
							return ecg;
						}
					}
					this.d[A_0] = null;
				}
				return ecg;
			}
		}
		return null;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
	private void a()
	{
		this.e = new Dictionary<string, fu>();
		this.d = new Dictionary<Texture2D, ecg>();
		this.h = Directory.GetFiles(Path.Combine(this.c.RootDirectory, "Locale\\Masks"), "*.pak");
		this.f = new long[this.h.Length];
		this.g = new FileStream[this.h.Length];
		for (int i = 0; i < this.h.Length; i++)
		{
			FileStream fileStream = File.OpenRead(this.h[i]);
			try
			{
				BinaryReader binaryReader = new BinaryReader(fileStream);
				int num = binaryReader.ReadInt32();
				if (num > 0)
				{
					for (int j = 0; j < num; j++)
					{
						string text = binaryReader.ReadString();
						fu fu = new fu();
						fu.a = binaryReader.ReadInt64();
						fu.b = binaryReader.ReadInt64();
						fu.c = i;
						if (text != null)
						{
							this.e[text.ToLowerInvariant()] = fu;
						}
					}
				}
				this.f[i] = binaryReader.ReadInt64();
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 111))
				{
					string a_ = ki.a("[Dynamic Resource Manager] - Error occurred while attempting to read the texture mask map. Exception: {0}.", new object[]
					{
						ex
					});
					cvq.n7(LogSeverity.Error, 111, a_);
				}
			}
			finally
			{
				fileStream.Close();
			}
		}
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x0001DA60 File Offset: 0x0001BC60
	private void a(Texture2D A_0)
	{
		if (A_0 != null)
		{
			this.d.Remove(A_0);
		}
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x0001DA78 File Offset: 0x0001BC78
	private static void a(b5s A_0)
	{
		IDisposable disposable = A_0.b as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
		}
		A_0.b = null;
	}

	// Token: 0x04000549 RID: 1353
	private Dictionary<string, b5s> a = new Dictionary<string, b5s>();

	// Token: 0x0400054A RID: 1354
	private HashSet<string> b = new HashSet<string>();

	// Token: 0x0400054B RID: 1355
	private ContentManager c;

	// Token: 0x0400054C RID: 1356
	private Dictionary<Texture2D, ecg> d;

	// Token: 0x0400054D RID: 1357
	private Dictionary<string, fu> e;

	// Token: 0x0400054E RID: 1358
	private long[] f;

	// Token: 0x0400054F RID: 1359
	private FileStream[] g;

	// Token: 0x04000550 RID: 1360
	private string[] h;

	// Token: 0x04000551 RID: 1361
	private double i = -1.0;

	// Token: 0x04000552 RID: 1362
	private bool j;
}
