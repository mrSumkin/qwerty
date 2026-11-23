using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.Design;

// Token: 0x02000220 RID: 544
public sealed class b2e
{
	// Token: 0x06000F20 RID: 3872 RVA: 0x0003F798 File Offset: 0x0003D998
	public string g()
	{
		return this.b;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
	public void d(string A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.a();
		}
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
	public string f()
	{
		return this.d;
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0003F7C8 File Offset: 0x0003D9C8
	public string j()
	{
		return this.c;
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x0003F7D0 File Offset: 0x0003D9D0
	public bool h()
	{
		return this.a;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0003F7E4 File Offset: 0x0003D9E4
	public Dictionary<string, c5k> e()
	{
		return this.f;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0003F7EC File Offset: 0x0003D9EC
	public b2e()
	{
		this.a(true);
		this.a();
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0003F84C File Offset: 0x0003DA4C
	public c5k a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		string text = A_0.ToLowerInvariant();
		c5k c5k;
		this.f.TryGetValue(text, out c5k);
		if (c5k == null && !this.g.Contains(text))
		{
			try
			{
				c5k = eoq.DeserializeFromBinaryFileCompressed<c5k>(Path.ChangeExtension(Path.Combine(this.c, text), "upeb"), dds.a(), true);
			}
			catch (Exception ex)
			{
				cvq service = bpo.GetService<cvq>();
				if (service != null && service.n8() && service.n9(LogSeverity.Error, 112))
				{
					string a_ = string.Format("[Id_Playfield] - Entity blueprint library failed to load blueprint '{0}'. The blueprint has been marked invalid. Exception: {1}", A_0, ex.ToString());
					service.n7(LogSeverity.Error, 112, a_);
				}
			}
			if (c5k == null)
			{
				this.g.Add(text);
			}
			else
			{
				this.f[text] = c5k;
			}
		}
		return c5k;
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0003F93C File Offset: 0x0003DB3C
	public List<c5k> c()
	{
		List<c5k> list = new List<c5k>();
		try
		{
			foreach (string text in Directory.GetFiles(this.c, "*.upeb", 1))
			{
				try
				{
					string a_ = text.Substring(this.c.Length, text.Length - (this.c.Length + 4)).ToLowerInvariant().TrimStart(new char[]
					{
						'\\'
					});
					c5k c5k = this.a(a_);
					if (c5k != null)
					{
						list.Add(c5k);
					}
				}
				catch
				{
				}
			}
		}
		catch (Exception ex)
		{
			cvq service = bpo.GetService<cvq>();
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 112))
			{
				string a_2 = "[Playfield] - Blueprints Library failed to retrieve all blueprints. Exception: " + ex.ToString();
				service.n7(LogSeverity.Error, 112, a_2);
			}
		}
		Dictionary<string, c5k> dictionary = new Dictionary<string, c5k>();
		this.a(dictionary);
		list.AddRange(dictionary.Values);
		return list;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0003FA68 File Offset: 0x0003DC68
	public d4x c(string A_0)
	{
		d4x result;
		this.e.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0003FA88 File Offset: 0x0003DC88
	public b0b b(string A_0)
	{
		Stream stream = null;
		string key = null;
		if (this.a)
		{
			key = A_0.ToLowerInvariant();
			this.h.TryGetValue(key, out stream);
		}
		if (stream == null)
		{
			stream = new MemoryStream(File.ReadAllBytes(Path.ChangeExtension(Path.Combine(this.d, A_0), b0b.a)));
			if (this.a)
			{
				this.h[key] = stream;
			}
		}
		stream.Position = 0L;
		b0b b0b = eoq.DeserializeFromBinary<b0b>(stream, dds.a(), true, true);
		b0b.v();
		b0b.y();
		return b0b;
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0003FB1C File Offset: 0x0003DD1C
	public void i()
	{
		this.d();
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0003FB28 File Offset: 0x0003DD28
	public void d()
	{
		foreach (Stream stream in this.h.Values)
		{
			stream.Dispose();
		}
		this.h.Clear();
		this.f.Clear();
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0003FB9C File Offset: 0x0003DD9C
	public void b()
	{
		this.a(this.f);
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0003FBAC File Offset: 0x0003DDAC
	private void a(Dictionary<string, c5k> A_0)
	{
		foreach (string text in Directory.GetFiles(this.d, "*.ue", 1))
		{
			string text2 = text.Substring(this.d.Length).TrimStart(new char[]
			{
				'\\'
			});
			text2 = text2.Substring(0, text2.Length - 3);
			c5k c5k = new c5k();
			c5k.e(Path.GetFileNameWithoutExtension(text));
			c5k.f()[dg7.a] = text2;
			c5k.b("ProtoEn");
			c5k.d("");
			bool flag = false;
			string[] array = text2.Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			for (int j = 0; j < array.Length - 1; j++)
			{
				string text3 = array[j];
				GeneralEntityCategory a_;
				if (flag)
				{
					if (!string.IsNullOrEmpty(c5k.e()))
					{
						c5k c5k2 = c5k;
						c5k2.d(c5k2.e() + ".");
					}
					c5k c5k3 = c5k;
					c5k3.d(c5k3.e() + text3);
				}
				else if (Enum.TryParse<GeneralEntityCategory>(text3, out a_))
				{
					c5k.a(a_);
					flag = true;
				}
			}
			if (!flag)
			{
				c5k.a(GeneralEntityCategory.Miscellaneous);
				c5k.d("Prototypes");
			}
			A_0[text2.ToLowerInvariant()] = c5k;
		}
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0003FD1C File Offset: 0x0003DF1C
	private void a(bool A_0)
	{
		b2e.a a = new b2e.a();
		a.a = this;
		a.b = bpo.GetService<cvq>();
		ei2 service = bpo.GetService<ei2>();
		this.e.Clear();
		if (service != null)
		{
			service.av2(new Func<Type, bool>(a.a));
			if (A_0)
			{
				service.avy(new EventHandler<EventArgs>(this.a));
			}
		}
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x0003FD84 File Offset: 0x0003DF84
	private void a(object A_0, EventArgs A_1)
	{
		this.a(false);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0003FD90 File Offset: 0x0003DF90
	private bool a(Type A_0, cvq A_1)
	{
		object[] customAttributes = A_0.GetCustomAttributes(typeof(edy), false);
		if (customAttributes.Length != 0)
		{
			string text = ((edy)customAttributes[0]).a();
			if (!string.IsNullOrWhiteSpace(text))
			{
				if (this.e.ContainsKey(text))
				{
					if (A_1 != null && A_1.n8() && A_1.n9(LogSeverity.Error, 112))
					{
						string a_ = string.Format("[Playfield] - Blueprints library detected duplicate entity template '{0}'", text);
						A_1.n7(LogSeverity.Error, 112, a_);
					}
					return false;
				}
				try
				{
					d4x value = Activator.CreateInstance(A_0) as d4x;
					this.e[text] = value;
					return true;
				}
				catch (Exception ex)
				{
					if (A_1 != null && A_1.n8() && A_1.n9(LogSeverity.Error, 112))
					{
						string a_2 = string.Format("[Id_Playfield] - Failed to create an instance of enitity template of type '{0}'. Exception: {1}", A_0.FullName, ex.ToString());
						A_1.n7(LogSeverity.Error, 112, a_2);
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0003FE98 File Offset: 0x0003E098
	private void a()
	{
		string rootDirectory = bpo.GetServiceOrThrow<d67>().lh().RootDirectory;
		if (string.IsNullOrEmpty(this.b))
		{
			this.c = rootDirectory;
			this.d = rootDirectory;
			return;
		}
		this.c = Path.Combine(rootDirectory, this.b);
		this.d = Path.Combine(this.c, "..\\Prototypes");
	}

	// Token: 0x04000910 RID: 2320
	private bool a = true;

	// Token: 0x04000911 RID: 2321
	private string b = "";

	// Token: 0x04000912 RID: 2322
	private string c;

	// Token: 0x04000913 RID: 2323
	private string d;

	// Token: 0x04000914 RID: 2324
	private Dictionary<string, d4x> e = new Dictionary<string, d4x>();

	// Token: 0x04000915 RID: 2325
	private Dictionary<string, c5k> f = new Dictionary<string, c5k>();

	// Token: 0x04000916 RID: 2326
	private HashSet<string> g = new HashSet<string>();

	// Token: 0x04000917 RID: 2327
	private Dictionary<string, Stream> h = new Dictionary<string, Stream>();

	// Token: 0x02000221 RID: 545
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x0003FF04 File Offset: 0x0003E104
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(d4x).IsAssignableFrom(A_0) && this.a.a(A_0, this.b);
		}

		// Token: 0x04000918 RID: 2328
		public b2e a;

		// Token: 0x04000919 RID: 2329
		public cvq b;
	}
}
