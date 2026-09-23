# Bangumi for 10.10

![Bangumi for 10.10](poster.png)

[![Build](https://github.com/TGRonin/jellyfin-plugin-bangumi/actions/workflows/build.yml/badge.svg)](https://github.com/TGRonin/jellyfin-plugin-bangumi/actions/workflows/build.yml)

[bgm.tv](https://bgm.tv) 元数据源插件的 **Jellyfin 10.10 专用**维护分支。
在保持 .NET 8 / Jellyfin 10.10 兼容的前提下，持续把上游新版本的功能与问题修复同步复现到本分支。

> 本项目是 [kookxiang/jellyfin-plugin-bangumi](https://github.com/kookxiang/jellyfin-plugin-bangumi) 的独立 fork，基线为上游 tag `1.7.2`。
> 上游自 `1.7.3` 起转向 Jellyfin 10.11（.NET 9），master 已支持 Jellyfin 12。
> **如果你在使用 Jellyfin 10.11 或更新版本，请直接使用上游插件**，本分支只服务 10.10.x。

## 与官方版的区别

| | 官方版 | 本分支 |
|---|---|---|
| 支持 Jellyfin | 10.11 / 10.12 | **10.10.x**（.NET 8） |
| 插件 GUID | `41b59f1b-…` | `7e0e9030-598d-4709-814e-6a91dfed26f0` |
| 显示名称 | Bangumi | Bangumi for 10.10 |
| 代码基线 | 上游持续更新 | 上游 `1.7.2` + 逐步同步的功能 |
| 与官方版关系 | — | 独立插件，**可同时安装、互不影响** |

因为 GUID 不同，本插件不会覆盖官方版；两者可以共存。也正因为如此，官方版里已保存的设置（如 bgm.tv 授权）**不会自动带入**，首次安装需重新配置一次。

媒体库中已刮削的 Bangumi ID **不受影响**：两个版本使用相同的 provider 标识，切换或共存都无需重新刮削。

## 功能

继承自上游 `1.7.2`：

- 番剧、电影、书籍、人物的中文元数据与图片刮削
- 播放进度回传至 bgm.tv
- 离线数据库（离线档案）支持，缓解国内访问不稳定
- 多种文件名、集数、季度的解析规则与特别篇识别
- 丰富的刮削行为配置（标题偏好、季号猜测、搜索范围等）

在此基础上按开发计划逐步同步上游后续功能与修复（如自定义 bgm.tv 站点地址、代理支持、Anitomy 剧集解析器、各类解析与容错修复等）。已同步的内容见各版本 Release 说明。

## 下载

- 稳定版：<https://github.com/TGRonin/jellyfin-plugin-bangumi/releases/latest>
- 开发快照：<https://github.com/TGRonin/jellyfin-plugin-bangumi/releases/tag/ci>

## 安装

### 通过插件库（推荐）

1. Jellyfin 控制台 → **插件** → **存储库** → 右上 `+`
2. 名称随意，URL 填：
   ```
   https://tgronin.github.io/jellyfin-plugin-bangumi/repository.json
   ```
3. 保存后在 **目录** 中找到 *Bangumi for 10.10* 安装

此方式安装后可在后台直接检查并更新到新版本。

### 手动安装

1. 从 Release 下载 `Jellyfin.Plugin.Bangumi.zip` 并解压
2. 将解压出的全部文件放入 `Jellyfin 数据目录/Plugins/BangumiFor1010/`（目录名可自定）
3. 重新启动 Jellyfin

## 构建与发布

- push 到 `master` 即触发 GitHub Actions 构建，产出 dll 与开发快照
- 打 `v` 前缀 tag 并创建 Release 即发布新版本，插件库 manifest 自动更新
- 版本号由 tag 加提交距离自动推导，无需手工维护

## Emby

构建同时产出 Emby 版本（*Bangumi Lite for 10.10*），要求 Emby `4.9.0.12` 及以上。
Emby 版非本分支重点，功能与修复以 Jellyfin 版为准。

## 致谢与许可

- 基于 [kookxiang/jellyfin-plugin-bangumi](https://github.com/kookxiang/jellyfin-plugin-bangumi) fork，感谢上游作者与所有贡献者
- 遵循 **GPL-2.0**，见 [LICENSE](LICENSE)
